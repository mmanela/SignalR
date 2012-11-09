﻿// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved. See License.md in the project root for license information.

using System;
using System.Collections.Generic;

namespace Microsoft.AspNet.SignalR
{
    public interface ISubscriber
    {
        IEnumerable<string> EventKeys { get; }

        Func<string> GetCursor { get; set; }

        string Identity { get; }

        event Action<string> EventAdded;

        event Action<string> EventRemoved;
    }
}
