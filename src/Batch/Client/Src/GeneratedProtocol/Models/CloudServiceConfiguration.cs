// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Batch.Protocol.Models
{
    using System.Linq;

    /// <summary>
    /// The configuration for nodes in a pool based on the Azure Cloud
    /// Services platform.
    /// </summary>
    public partial class CloudServiceConfiguration
    {
        /// <summary>
        /// Initializes a new instance of the CloudServiceConfiguration class.
        /// </summary>
        public CloudServiceConfiguration() { }

        /// <summary>
        /// Initializes a new instance of the CloudServiceConfiguration class.
        /// </summary>
        /// <param name="osFamily">The Azure Guest OS family to be installed
        /// on the virtual machines in the pool.</param>
        /// <param name="targetOSVersion">The Azure Guest OS version to be
        /// installed on the virtual machines in the pool.</param>
        /// <param name="currentOSVersion">The Azure Guest OS Version
        /// currently installed on the virtual machines in the pool. This may
        /// differ from targetOSVersion if the pool state is
        /// Upgrading.</param>
        public CloudServiceConfiguration(string osFamily, string targetOSVersion = default(string), string currentOSVersion = default(string))
        {
            OsFamily = osFamily;
            TargetOSVersion = targetOSVersion;
            CurrentOSVersion = currentOSVersion;
        }

        /// <summary>
        /// Gets or sets the Azure Guest OS family to be installed on the
        /// virtual machines in the pool.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "osFamily")]
        public string OsFamily { get; set; }

        /// <summary>
        /// Gets or sets the Azure Guest OS version to be installed on the
        /// virtual machines in the pool.
        /// </summary>
        /// <remarks>
        /// The default value is * which specifies the latest operating system
        /// version for the specified OS family.
        /// </remarks>
        [Newtonsoft.Json.JsonProperty(PropertyName = "targetOSVersion")]
        public string TargetOSVersion { get; set; }

        /// <summary>
        /// Gets or sets the Azure Guest OS Version currently installed on the
        /// virtual machines in the pool. This may differ from
        /// targetOSVersion if the pool state is Upgrading.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "currentOSVersion")]
        public string CurrentOSVersion { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (OsFamily == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "OsFamily");
            }
        }
    }
}
