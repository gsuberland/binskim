﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.CodeAnalysis.BinSkim.Rules {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.CodeAnalysis.BinSkim.Rules.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to built with {0} compiler version {1} (Front end version {2}).
        /// </summary>
        internal static string BuildWithSecureTools_BadModule {
            get {
                return ResourceManager.GetString("BuildWithSecureTools_BadModule", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &apos;{0}&apos; was compiled with one or more modules which were not built using minimum required tool versions (compiler version {1}, linker version {2}). More recent tool chains contain mitigations that make it more difficult for attackers to exploit vulnerabilities in programs they produce. To resolve this issue, compile and/or link your binary with more recent tools. If you are servicing a product where the tool chain cannot be modified (e.g. producing a hotfix for an already shipped version) ignore this warning. [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string BuildWithSecureTools_Fail {
            get {
                return ResourceManager.GetString("BuildWithSecureTools_Fail", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &apos;{0}&apos; was built with a tool chain that satisfies configured policy (compiler minimum version {1}, linker minimum version {2})..
        /// </summary>
        internal static string BuildWithSecureTools_Pass {
            get {
                return ResourceManager.GetString("BuildWithSecureTools_Pass", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &apos;{0}&apos; is a C or C++ binary built with function(s) ({1}) that disable the stack protector. The stack protector (/GS) is a security feature of the compiler which makes it more difficult to exploit stack buffer overflow memory corruption vulnerabilities. Disabling the stack protector, even on a function-by-function basis, is disallowed by SDL policy. To resolve this issue, remove occurrences of __declspec(safebuffers) from your code. If the additional code inserted by the stack protector has been shown in prof [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string DoNotDisableStackProtectionForFunctions_Fail {
            get {
                return ResourceManager.GetString("DoNotDisableStackProtectionForFunctions_Fail", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &apos;{0}&apos; is a C or C++ binary built with the stack protector buffer security feature enabled which does not disable protection for any individual functions (via __declspec(safebuffers), making it more difficult for attackers to exploit stack buffer overflow memory corruption vulnerabilities..
        /// </summary>
        internal static string DoNotDisableStackProtectionForFunctions_Pass {
            get {
                return ResourceManager.GetString("DoNotDisableStackProtectionForFunctions_Pass", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &apos;{0}&apos; was built with a version of {1} which is subject to the following issues: {2}. To resolve this, {3}. The source files that triggered this were: {4}.
        /// </summary>
        internal static string DoNotIncorporateVulnerableBinaries_Fail {
            get {
                return ResourceManager.GetString("DoNotIncorporateVulnerableBinaries_Fail", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &apos;{0}&apos; does not incorporate any known vulnerable dependencies, as configured by current policy..
        /// </summary>
        internal static string DoNotIncorporateVulnerableBinaries_Pass {
            get {
                return ResourceManager.GetString("DoNotIncorporateVulnerableBinaries_Pass", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &apos;{0}&apos; has the imports section marked executable. Because the loader will always mark the imports section as writable, it is important to mark this section as non-executable, so that an attacker cannot place shellcode here. To resolve this issue, ensure that your program does not mark the imports section as executable. Look for uses of /SECTION or /MERGE on the linker command line, or #pragma segment in source code, which change the imports section to be executable, or which merge the &quot;.rdata&quot; segment into a [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string DoNotMarkImportsSectionAsExecutable_Fail {
            get {
                return ResourceManager.GetString("DoNotMarkImportsSectionAsExecutable_Fail", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &apos;{0}&apos; does not have an imports section that is marked as executable, helping to prevent the exploitability of code vulnerabilities..
        /// </summary>
        internal static string DoNotMarkImportsSectionAsExecutable_Pass {
            get {
                return ResourceManager.GetString("DoNotMarkImportsSectionAsExecutable_Pass", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &apos;{0}&apos; contains PE section(s) ({1}) that are both writable and executable. Writable and executable memory segments make it easier for an attacker to exploit memory corruption vulnerabilities, because it gives the attacker location(s) where they can place shellcode that can execute. To resolve this issue, configure your toolchain to not emit memory sections that are writable and executable. For example, look for uses of /SECTION on the linker command line for C and C++ programs, or #pragma section in C and C+ [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string DoNotMarkWritableSectionsAsExecutable_Fail {
            get {
                return ResourceManager.GetString("DoNotMarkWritableSectionsAsExecutable_Fail", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &apos;{0}&apos; contains no data or code sections marked as both shared and executable, helping to prevent the exploitability of code vulnerabilities..
        /// </summary>
        internal static string DoNotMarkWritableSectionsAsExecutable_Pass {
            get {
                return ResourceManager.GetString("DoNotMarkWritableSectionsAsExecutable_Pass", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &apos;{0}&apos; has a section alignment ({1}) that is smaller than page size ({2})..
        /// </summary>
        internal static string DoNotMarkWritableSectionsAsExecutable_UnexpectedSectionAligment {
            get {
                return ResourceManager.GetString("DoNotMarkWritableSectionsAsExecutable_UnexpectedSectionAligment", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &apos;{0}&apos; contains one or more code or data sections ({1}) which are marked as both shared and writable. Because these sections are shared across processes, this condition might permit a process with low privilege to mutate memory in a higher privilege process. If you do not actually require that a section be both writable and shared, remove one or both of these attributes (by modifying your .DEF file, the appropriate linker /section switch arguments, etc.). If you are required to share common data across proce [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string DoNotMarkWritableSectionsAsShared_Fail {
            get {
                return ResourceManager.GetString("DoNotMarkWritableSectionsAsShared_Fail", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &apos;{0}&apos; contains no data or code sections marked as both shared and writable, helping to prevent the exploitability of code vulnerabilities..
        /// </summary>
        internal static string DoNotMarkWritableSectionsAsShared_Pass {
            get {
                return ResourceManager.GetString("DoNotMarkWritableSectionsAsShared_Pass", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &apos;{0}&apos; is a C or C++binary that enables the stack protection feature but the security cookie could not be located. The binary may be corrupted..
        /// </summary>
        internal static string DoNotModifyStackProtectionCookie_CouldNotLocateCookie_Fail {
            get {
                return ResourceManager.GetString("DoNotModifyStackProtectionCookie_CouldNotLocateCookie_Fail", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &apos;{0}&apos; is a C or C++ binary that interferes with the stack protector. The stack protector (/GS) is a security feature of the compiler which makes it more difficult to exploit stack buffer overflow memory corruption vulnerabilities. The stack protector relies on a random number, called the &quot;security cookie&quot;, to detect these buffer overflows. This &apos;cookie&apos; is statically linked with your binary from a Visual C++ library in the form of the symbol __security_cookie. On recent Windows versions, the loader looks fo [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string DoNotModifyStackProtectionCookie_Fail {
            get {
                return ResourceManager.GetString("DoNotModifyStackProtectionCookie_Fail", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &apos;{0}&apos; is  C or C++binary that does not contain a load config table, which indicates either indicates that it was compiled and linked with a version of the compiler that precedes stack protection features or is a binary (such as an ngen&apos;ed assembly) that is not subject to relevant security issues..
        /// </summary>
        internal static string DoNotModifyStackProtectionCookie_NoLoadConfig_Pass {
            get {
                return ResourceManager.GetString("DoNotModifyStackProtectionCookie_NoLoadConfig_Pass", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &apos;{0}&apos; is a C or C++ binary built with the buffer security feature that properly preserves the stack protecter cookie. This has the effect of enabling a significant increase in entropy provided by the operating system over that produced by the C runtime start-up code..
        /// </summary>
        internal static string DoNotModifyStackProtectionCookie_Pass {
            get {
                return ResourceManager.GetString("DoNotModifyStackProtectionCookie_Pass", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &apos;{0}&apos; appears to be an obsolete library (version {1}) for which there are known security vulnerabilities. To resolve this issue, obtain a version of {0} that is newer than version {2}. If this binary is not in fact {0}, ignore this warning..
        /// </summary>
        internal static string DoNotShipVulnerabilities_Fail {
            get {
                return ResourceManager.GetString("DoNotShipVulnerabilities_Fail", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to vulnerable binary name and version metadata .
        /// </summary>
        internal static string DoNotShipVulnerabilities_MissingPolicy_InternalError {
            get {
                return ResourceManager.GetString("DoNotShipVulnerabilities_MissingPolicy_InternalError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Version information for &apos;{0}&apos; could not be parsed. The binary therefore could not be verified not to be an obsolete binary that is known to be vulnerable to one or more security problems..
        /// </summary>
        internal static string DoNotShipVulnerableBinaries_CouldNotParseVersion_Fail {
            get {
                return ResourceManager.GetString("DoNotShipVulnerableBinaries_CouldNotParseVersion_Fail", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &apos;{0}&apos; is not known to be an obsolete binary that is vulnerable to one or more security problems..
        /// </summary>
        internal static string DoNotShipVulnerableBinaries_Pass {
            get {
                return ResourceManager.GetString("DoNotShipVulnerableBinaries_Pass", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &apos;{0}&apos; is not marked as DYNAMICBASE. This means that the binary is not eligible for relocation by Address Space Layout Randomization (ASLR). ASLR is an important mitigation that makes it more difficult for attackers to exploit memory corruption vulnerabilities. To resolve this issue, configure your tool chain to build with this feature enabled. For C and C++ binaries, add /DYNAMICBASE to your linker command line. For .NET applications, use a compiler shipping with Visual Studio 2008 or later..
        /// </summary>
        internal static string EnableAddressSpaceLayoutRandomization_NotDynamicBase_Fail {
            get {
                return ResourceManager.GetString("EnableAddressSpaceLayoutRandomization_NotDynamicBase_Fail", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &apos;{0}&apos; is properly compiled to enable address space layout randomization, reducing an attacker&apos;s ability to exploit code in well-known locations..
        /// </summary>
        internal static string EnableAddressSpaceLayoutRandomization_Pass {
            get {
                return ResourceManager.GetString("EnableAddressSpaceLayoutRandomization_Pass", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &apos;{0}&apos; is marked as DYNAMICBASE but relocation data has been stripped from the image, preventing address space layout randomization. .
        /// </summary>
        internal static string EnableAddressSpaceLayoutRandomization_RelocsStripped_Fail {
            get {
                return ResourceManager.GetString("EnableAddressSpaceLayoutRandomization_RelocsStripped_Fail", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &apos;{0}&apos; is a Windows CE image but does not contain any relocation data, preventing address space layout randomization..
        /// </summary>
        internal static string EnableAddressSpaceLayoutRandomization_WinCENoRelocationSection_Fail {
            get {
                return ResourceManager.GetString("EnableAddressSpaceLayoutRandomization_WinCENoRelocationSection_Fail", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &apos;{0}&apos; does not enable the control flow guard mitigation..
        /// </summary>
        internal static string EnableControlFlowGuard_Fail {
            get {
                return ResourceManager.GetString("EnableControlFlowGuard_Fail", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &apos;{0} does not contain a load configuration table, indicating that it does not enable the control flow guard mitigation..
        /// </summary>
        internal static string EnableControlFlowGuard_NoLoadConfigTable_Fail {
            get {
                return ResourceManager.GetString("EnableControlFlowGuard_NoLoadConfigTable_Fail", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &apos;{0}&apos; enables the control flow guard mitigation..
        /// </summary>
        internal static string EnableControlFlowGuard_Pass {
            get {
                return ResourceManager.GetString("EnableControlFlowGuard_Pass", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &apos;{0}&apos; was compiled at too low a warning level (effective warning level {1} for one or more modules). Warning level 3 enables important static analysis in the compiler to flag bugs that can lead to memory corruption, information disclosure, or double-free vulnerabilities. To resolve this issue, compile at warning level 3 or higher by supplying /W3, /W4, or /Wall to the compiler, and resolve the warnings emitted. An example compiler command line triggering this check: {2}
        ///Modules triggering this check: {3}.
        /// </summary>
        internal static string EnableCriticalCompilerWarnings_InsufficientWarningLevel_Fail {
            get {
                return ResourceManager.GetString("EnableCriticalCompilerWarnings_InsufficientWarningLevel_Fail", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &apos;{0}&apos; was compiled at a secure warning level ({1}) and does not include any modules that disable specific warnings that are required by policy. As a result, there is a greater likelihood that memory corruption, information disclosre, double-free and other security-related vulnerabilities do not exist in code..
        /// </summary>
        internal static string EnableCriticalCompilerWarnings_Pass {
            get {
                return ResourceManager.GetString("EnableCriticalCompilerWarnings_Pass", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &apos;{0}&apos; contains code from an unknown language, preventing a comprehensive analysis of the compiler warning settings. The language could not be identified for the following modules: {1}.
        /// </summary>
        internal static string EnableCriticalCompilerWarnings_UnknownModuleLanguage_Fail {
            get {
                return ResourceManager.GetString("EnableCriticalCompilerWarnings_UnknownModuleLanguage_Fail", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &apos;{0}&apos; disables compiler warning(s) which are required by policy. A compiler warning is typically required if it has a high likelihood of flagging memory corruption, information disclosure, or double-free vulnerabilities. To resolve this issue, enable the indicated warning(s) by removing /Wxxxx switches (where xxxx is a warning id indicated here) from your command line, and resolve any warnings subsequently raised during compilation. An example compiler command line triggering this check was: {1}
        ///Modules tr [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string EnableCriticalCompilerWarnings_WarningsDisabled_Fail {
            get {
                return ResourceManager.GetString("EnableCriticalCompilerWarnings_WarningsDisabled_Fail", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &apos;{0}&apos; does not declare itself as high entropy ASLR compatible. High entropy allows Address Space Layout Randomization to be more effective in mitigating memory corruption vulnerabilities. To resolve this issue, configure your tool chain to mark the program high entropy compatible; e.g. by supplying /HIGHENTROPYVA as well as /LARGEADDRESSAWARE to the C or C++ linker command line..
        /// </summary>
        internal static string EnableHighEntropyVirtualAddresses_NeitherHighEntropyVANorLargeAddressAware_FAIL {
            get {
                return ResourceManager.GetString("EnableHighEntropyVirtualAddresses_NeitherHighEntropyVANorLargeAddressAware_FAIL", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &apos;{0}&apos; does not declare itself as high entropy ASLR compatible. High entropy allows Address Space Layout Randomization to be more effective in mitigating memory corruption vulnerabilities. To resolve this issue, configure your tool chain to mark the program high entropy compatible; e.g. by supplying /HIGHENTROPYVA to the C or C++ linker command line. (This image was determined to have been properly compiled as /LARGEADDRESSAWARE.).
        /// </summary>
        internal static string EnableHighEntropyVirtualAddresses_NoHighEntropyVA_FAIL {
            get {
                return ResourceManager.GetString("EnableHighEntropyVirtualAddresses_NoHighEntropyVA_FAIL", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &apos;{0}&apos; does not declare itself as high entropy ASLR compatible. High entropy allows Address Space Layout Randomization to be more effective in mitigating memory corruption vulnerabilities. To resolve this issue, configure your tool chain to mark the program high entropy compatible by supplying /LARGEADDRESSAWARE to the C or C++ linker command line. (This image was determined to have been properly compiled as /HIGHENTROPYVA.).
        /// </summary>
        internal static string EnableHighEntropyVirtualAddresses_NoLargeAddressAware_FAIL {
            get {
                return ResourceManager.GetString("EnableHighEntropyVirtualAddresses_NoLargeAddressAware_FAIL", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &apos;{0}&apos; is high entropy ASLR compatible, reducing an attacker&apos;s ability to exploit code in well-known locations..
        /// </summary>
        internal static string EnableHighEntropyVirtualAddresses_Pass {
            get {
                return ResourceManager.GetString("EnableHighEntropyVirtualAddresses_Pass", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to has an empty SE handler table in the load configuration table.
        /// </summary>
        internal static string EnableSafeSEH_EmptySEHandlerTable_Fail {
            get {
                return ResourceManager.GetString("EnableSafeSEH_EmptySEHandlerTable_Fail", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &apos;{0}&apos; is an x86 binary which {1}, indicating that it does not enable the SafeSEH mitigation. SafeSEH makes it more difficult to exploit memory corruption vulnerabilities that can overwrite SEH control blocks on the stack, by verifying that the location to which a thrown SEH exception would jump is indeed defined as an exception handler in the source program (and not shellcode). To resolve this issue, supply the /SafeSEH flag on the linker command line. Note that you will need to configure your build system  [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string EnableSafeSEH_Formatted_Fail {
            get {
                return ResourceManager.GetString("EnableSafeSEH_Formatted_Fail", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to contains an unexpectedly small load configuration table {size 0}.
        /// </summary>
        internal static string EnableSafeSEH_LoadConfigurationIsTooSmall_Fail {
            get {
                return ResourceManager.GetString("EnableSafeSEH_LoadConfigurationIsTooSmall_Fail", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to does not contain a load configuration table.
        /// </summary>
        internal static string EnableSafeSEH_NoLoadConfigurationTable_Fail {
            get {
                return ResourceManager.GetString("EnableSafeSEH_NoLoadConfigurationTable_Fail", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &apos;{0}&apos; is an x86 binary that does not use SEH, making it an invalid target for exploits that attempt to replace SEH jump targets with attacker-controlled shellcode..
        /// </summary>
        internal static string EnableSafeSEH_NoSEH_Pass {
            get {
                return ResourceManager.GetString("EnableSafeSEH_NoSEH_Pass", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &apos;{0}&apos; is an x86 binary that enables SafeSEH, a mitigation that verifies SEH exception jump targets are defined as exception handlers in the program (and not shellcode)..
        /// </summary>
        internal static string EnableSafeSEH_SafeSEHEnabled_Pass {
            get {
                return ResourceManager.GetString("EnableSafeSEH_SafeSEHEnabled_Pass", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to has zero SE handlers in the load configuration table.
        /// </summary>
        internal static string EnableSafeSEH_ZeroCountSEHandlers_Fail {
            get {
                return ResourceManager.GetString("EnableSafeSEH_ZeroCountSEHandlers_Fail", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &apos;{0}&apos; is a C or C++ binary built with the stack protector buffer security feature disabled in one or more modules. The stack protector (/GS) is a security feature of the compiler which makes it more difficult to exploit stack buffer overflow memory corruption vulnerabilities. To resolve this issue, ensure that your code is compiled with the stack protector enabled by supplying /GS on the Visual C++ compiler command line. The affected modules were: {1}.
        /// </summary>
        internal static string EnableStackProtection_Fail {
            get {
                return ResourceManager.GetString("EnableStackProtection_Fail", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &apos;{0}&apos; is a C or C++ binary built with the stack protector buffer security feature enabled for all modules, making it more difficult for attackers to exploit stack buffer overflow memory corruption vulnerabilities. .
        /// </summary>
        internal static string EnableStackProtection_Pass {
            get {
                return ResourceManager.GetString("EnableStackProtection_Pass", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &apos;{0}&apos; contains code from an unknown language, preventing a comprehensive analysis of the stack protector buffer security features. The language could not be identified for the following modules: {1}..
        /// </summary>
        internal static string EnableStackProtection_UnknownModuleLanguage_Fail {
            get {
                return ResourceManager.GetString("EnableStackProtection_UnknownModuleLanguage_Fail", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &apos;{0}&apos; is a C or C++ binary that does not initialize the stack protector. The stack protector (/GS) is a security feature of the compiler which makes it more difficult to exploit stack buffer overflow memory corruption vulnerabilities. The stack protector requires access to entropy in order to be effective, which means a binary must initialize a random number generator at startup, by calling __security_init_cookie() as close to the binary&apos;s entry point as possible. Failing to do so will result in spurious bu [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string InitializeStackProtection_Fail {
            get {
                return ResourceManager.GetString("InitializeStackProtection_Fail", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &apos;{0}&apos; is a C or C++ binary that is not required to initialize the stack protection, as it does not contain executable code..
        /// </summary>
        internal static string InitializeStackProtection_NoCode_Pass {
            get {
                return ResourceManager.GetString("InitializeStackProtection_NoCode_Pass", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &apos;{0}&apos; is a C or C++ binary that does not make use of the stack protection buffer security feature. It is therefore not required to initialize the feature..
        /// </summary>
        internal static string InitializeStackProtection_NoFeatureUse_Pass {
            get {
                return ResourceManager.GetString("InitializeStackProtection_NoFeatureUse_Pass", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &apos;{0}&apos; is a C or C++ binary built with the buffer security feature that properly initializes the stack protecter. This has the effect of increasing the effectiveness of the feature and reducing spurious detections..
        /// </summary>
        internal static string InitializeStackProtection_Pass {
            get {
                return ResourceManager.GetString("InitializeStackProtection_Pass", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &apos;{0}&apos; is a 64-bit image with a preferred base address below the 4GB boundary. Having a preferred base address below this boundary triggers a compatibility mode in Address Space Layout Randomization (ASLR) on recent versions of Windows that reduces the number of locations to which ASLR may relocate the binary. This reduces the effectiveness of ASLR at mitigating memory corruption vulnerabilities. To resolve this issue, either use the default preferred base address by removing any uses of /baseaddress from co [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string LoadImageAboveFourGigabyteAddress_Fail {
            get {
                return ResourceManager.GetString("LoadImageAboveFourGigabyteAddress_Fail", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &apos;{0}&apos; is a 64-bit image with a base address that is &gt;= 4 gigabytes, increaseing the effectiveness of address space layout randomization (that helps prevent attackers from executing security-sensitive code in well-known locations)..
        /// </summary>
        internal static string LoadImageAboveFourGigabyteAddress_Pass {
            get {
                return ResourceManager.GetString("LoadImageAboveFourGigabyteAddress_Pass", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &apos;{0}&apos; is not marked NX compatible. The NXCompat bit, also known as &quot;Data Execution Prevention&quot; (DEP) or &quot;Execute Disable&quot; (XD), is a processor feature that allows a program to mark a piece of memory as non-executable. This helps mitigate memory corruption vulnerabilities by preventing an attacker from supplying direct shellcode in their exploit, because the exploit comes in the form of input data to the exploited program on a data segment, rather than on an executable code segment. To resolve this issue, en [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string MarkImageAsNXCompatible_Fail {
            get {
                return ResourceManager.GetString("MarkImageAsNXCompatible_Fail", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &apos;{0}&apos; is marked as NX compatible, helping to prevent attackers from executing code that is injected into data segments..
        /// </summary>
        internal static string MarkImageAsNXCompatible_Pass {
            get {
                return ResourceManager.GetString("MarkImageAsNXCompatible_Pass", resourceCulture);
            }
        }
    }
}
