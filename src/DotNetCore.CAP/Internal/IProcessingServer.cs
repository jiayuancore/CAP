// Copyright (c) .NET Core Community. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using System;
using System.Threading;
using System.Threading.Tasks;

namespace DotNetCore.CAP.Internal;

/// <inheritdoc />
/// <summary>
/// A process thread abstract of message process.
/// 消息进程的进程线程抽象
/// </summary>
public interface IProcessingServer : IDisposable
{
    Task Start(CancellationToken stoppingToken);
}