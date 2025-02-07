﻿// Copyright (c) .NET Core Community. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using System.Net.Http;
using System.Threading.Tasks;

namespace DotNetCore.CAP.Dashboard.GatewayProxy.Requester
{
    /// <summary>
    /// Http请求
    /// </summary>
    public interface IHttpRequester
    {
        Task<HttpResponseMessage> GetResponse(HttpRequestMessage request);
    }
}