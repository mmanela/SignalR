﻿// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved. See License.md in the project root for license information.

using System.Collections.Generic;
using Newtonsoft.Json;

namespace Microsoft.AspNet.SignalR.Hubs
{
    /// <summary>
    /// 
    /// </summary>
    public class ClientHubInvocation
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonIgnore]
        public string Target { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Hub { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Method { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public object[] Args { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public IDictionary<string, object> State { get; set; }
    }
}
