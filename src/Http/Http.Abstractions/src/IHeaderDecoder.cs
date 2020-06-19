// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Text;

namespace Microsoft.AspNetCore.Http
{
    // REVIEW: Will we use this same interface for header encoding?
    // If so, what should we name this? IHeaderEncodingSelector?
    public interface IHeaderDecoder
    {
        Encoding? GetEncoding(string headerName);
    }
}
