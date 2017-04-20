//
// Copyright (c) Microsoft.  All rights reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//

namespace Microsoft.Azure.Management.DataFactories.Models
{
    /// <summary>
    /// Azure Data Lake Analytics linked service.
    /// </summary>
    [AdfTypeName("AzureDataLakeAnalytics")]
    public class AzureDataLakeAnalyticsLinkedService : LinkedServiceTypeProperties
    {
        /// <summary>
        /// Required. Data Lake Analytics account name.
        /// </summary>
        [AdfRequired]
        public string AccountName { get; set; }

        /// <summary>
        /// Optional. Data Lake Analytics service URI.
        /// </summary>
        public string DataLakeAnalyticsUri { get; set; }

        /// <summary>
        /// Optional. Data Lake Analytics account subscription ID (if different from Data Factory account).
        /// </summary>
        public string SubscriptionId { get; set; }

        /// <summary>
        /// Optional. Data Lake Analytics account resource group name (if different from Data Factory account).
        /// </summary>
        public string ResourceGroupName { get; set; }

        /// <summary>
        /// Optional. The ID of the service principal used to authenticate against the Azure Data Lake Analytics account.
        /// </summary>
        public string ServicePrincipalId { get; set; }

        /// <summary>
        /// Optional. The key of the service principal used to authenticate against the Azure Data Lake Analytics account.
        /// </summary>
        public string ServicePrincipalKey { get; set; }

        /// <summary>
        /// Optional. The name or ID of the tenant to which the service principal belongs.
        /// </summary>
        public string Tenant { get; set; }

        /// <summary>
        /// OAuth authorization that may be used by ADF to access
        /// resources on your behalf. Each authorization is unique and may
        /// only be used once.
        /// </summary>
        public string Authorization { get; set; }

        /// <summary>
        /// OAuth session ID from the OAuth authorization session.
        /// Each session ID is unique and may only be used once.
        /// </summary>
        public string SessionId { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="AzureDataLakeAnalyticsLinkedService"/> class.
        /// </summary>
        public AzureDataLakeAnalyticsLinkedService()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AzureDataLakeAnalyticsLinkedService"/>
        /// class with required arguments.
        /// </summary>
        public AzureDataLakeAnalyticsLinkedService(string accountName) : this()
        {
            Ensure.IsNotNullOrEmpty(accountName, "accountName");
            this.AccountName = accountName;
        }
    }
}
