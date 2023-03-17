// Copyright (c) .NET Core Community. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using System;
using System.Threading.Tasks;
using DotNetCore.CAP.Internal;
using DotNetCore.CAP.Persistence;

namespace DotNetCore.CAP.Transport;

/// <summary>
/// 调度程序抽象
/// </summary>
public interface IDispatcher : IProcessingServer
{
    /// <summary>
    /// 排队发布消息
    /// </summary>
    /// <param name="message"></param>
    /// <returns></returns>
    ValueTask EnqueueToPublish(MediumMessage message);
    /// <summary>
    /// 
    /// </summary>
    /// <param name="message"></param>
    /// <param name="descriptor"></param>
    /// <returns></returns>

    ValueTask EnqueueToExecute(MediumMessage message, ConsumerExecutorDescriptor? descriptor = null);
    /// <summary>
    /// 
    /// </summary>
    /// <param name="message"></param>
    /// <param name="publishTime"></param>
    /// <param name="transaction"></param>
    /// <returns></returns>

    ValueTask EnqueueToScheduler(MediumMessage message, DateTime publishTime, object? transaction = null);
}