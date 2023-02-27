// Copyright (c) .NET Core Community. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace DotNetCore.CAP.Dashboard.NodeDiscovery
{
    /// <summary>
    /// 分布式节点发现
    /// </summary>
    public interface INodeDiscoveryProvider
    {
        /// <summary>
        /// 获取节点
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        IList<Node> GetNodes(CancellationToken cancellationToken = default);
        /// <summary>
        /// 注册节点
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task RegisterNode(CancellationToken cancellationToken = default);
    }
}