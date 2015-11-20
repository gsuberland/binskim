﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Composition;
using System.Reflection.PortableExecutable;
using Microsoft.CodeAnalysis.BinaryParsers.PortableExecutable;
using Microsoft.CodeAnalysis.BinSkim.Sdk;

namespace Microsoft.CodeAnalysis.BinSkim.Rules
{
    [Export(typeof(IBinarySkimmer))]
    public class LoadImageAboveFourGigabyteAddress : IBinarySkimmer, IRuleContext
    {
        public string Id { get { return RuleConstants.LoadImageAboveFourGigabyteAddressId; } }

        public string Name { get { return nameof(LoadImageAboveFourGigabyteAddress); } }

        public void Initialize(BinaryAnalyzerContext context) { return; }

        private static readonly Version s_winCeVersion70 = new Version(7, 0);

        public AnalysisApplicability CanAnalyze(BinaryAnalyzerContext context, out string reasonForNotAnalyzing)
        {
            PE portableExecutable = context.PE;
            AnalysisApplicability result = AnalysisApplicability.NotApplicableToSpecifiedTarget;

            reasonForNotAnalyzing = MetadataConditions.ImageIsNot64BitBinary;
            if (context.PE.PEHeaders.PEHeader.Magic != PEMagic.PE32Plus) { return result; }

            reasonForNotAnalyzing = MetadataConditions.ImageIsKernelModeBinary;
            if (portableExecutable.IsKernelMode) { return result; }

            reasonForNotAnalyzing = MetadataConditions.ImageIsResourceOnlyBinary;
            if (portableExecutable.IsResourceOnly) { return result; }

            return AnalysisApplicability.ApplicableToSpecifiedTarget;
        }

        public void Analyze(BinaryAnalyzerContext context)
        {
            PEHeader peHeader = context.PE.PEHeaders.PEHeader;

            UInt64 imageBase = peHeader.ImageBase;

            if (imageBase <= 0xFFFFFFFF)
            {
                // '{0}' is a 64-bit image with a preferred base address below the 4GB boundary. 
                // Having a preferred base address below this boundary triggers a compatibility 
                // mode in Address Space Layout Randomization (ASLR) on recent versions of 
                // Windows that reduces the number of locations to which ASLR may relocate the 
                // binary. This reduces the effectiveness of ASLR at mitigating memory corruption 
                // vulnerabilities. To resolve this issue, either use the default preferred base 
                // address by removing any uses of /baseaddress from compiler command lines, or 
                // /BASE from linker command lines (recommended), or configure your program to 
                // start at a base address above 4GB when compiled for 64 bit platforms (by 
                // changing the constant passed to /baseaddress / /BASE). Note that if you choose 
                // to continue using a custom preferred base address, you will need to make this 
                // modification only for 64-bit builds, as base addresses above 4GB are not valid 
                // for 32-bit binaries.
                context.Logger.Log(MessageKind.Fail, context,
                    RuleUtilities.BuildMessage(context,
                        RulesResources.LoadImageAboveFourGigabyteAddress_Fail));
                return;
            }

            // '{0}' is marked as NX compatible.
            context.Logger.Log(MessageKind.Pass, context,
                RuleUtilities.BuildMessage(context,
                    RulesResources.LoadImageAboveFourGigabyteAddress_Pass));
        }
    }
}
