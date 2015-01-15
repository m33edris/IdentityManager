﻿/*
 * Copyright 2014 Dominick Baier, Brock Allen
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *   http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */
 
using Microsoft.Owin;
using System.Collections.Generic;

namespace Thinktecture.IdentityManager
{
    /// <summary>
    /// Container for the OWIN environment.
    /// </summary>
    public class OwinEnvironmentService
    {
        readonly IOwinContext _context;

        internal OwinEnvironmentService(IOwinContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Gets the OWIN environment.
        /// </summary>
        /// <value>
        /// The environment.
        /// </value>
        public IDictionary<string, object> Environment 
        { 
            get
            {
                return _context.Environment;
            }
        }
    }
}