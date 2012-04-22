﻿using System;
using System.Threading;
using System.Net.Sockets;
using System.Net;

using Cet.Develop.WP.IO.Protocols;

/*
 * Copyright 2012 Mario Vernari (http://cetdevelop.codeplex.com/)
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */
namespace Cet.Develop.WP.IO
{
    public static class SocketExtensions
    {
        /// <summary>
        /// Return a concrete implementation of a socket client
        /// </summary>
        /// <param name="port"></param>
        /// <returns></returns>
        public static ICommClient GetClient(
            this Socket port)
        {
            return new IpClient(port);
        }

    }
}
