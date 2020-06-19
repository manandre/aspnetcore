// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

#nullable enable

using System.Text;
using Microsoft.AspNetCore.Http;

namespace Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Infrastructure
{
    internal class Utf8HeaderDecoder : IHeaderDecoder
    {
        public Encoding? GetEncoding(string headerName)
        {
            return Encoding.UTF8;
        }
    }
}
