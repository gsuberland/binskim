﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.CodeAnalysis.BinSkim.Sdk
{
    public interface IRuleContext
    {
        string Id { get; }

        string Name { get; }
    }
}
