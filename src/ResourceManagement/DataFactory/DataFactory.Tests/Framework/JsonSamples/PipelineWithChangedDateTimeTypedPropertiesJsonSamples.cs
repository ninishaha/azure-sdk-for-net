// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

namespace DataFactory.Tests.Framework.JsonSamples
{
    public class PipelineWithChangedDateTimeTypedPropertiesJsonSamples : JsonSampleCollection<PipelineWithChangedDateTimeTypedPropertiesJsonSamples>
    {
        [JsonSample(propertyBagKeys: new string[]
                    {
                        "properties.activities[0].typeProperties.webServiceParameters.DateTime1",
                        "properties.activities[0].typeProperties.webServiceParameters.DateTime2",
                        "properties.activities[0].typeProperties.webServiceParameters.DateTime3"
                    })]
        public const string AzureMLPipeline = @"
{
    name: ""My machine learning pipeline2"",
    properties: 
    {
        description : ""ML pipeline description"",
        hubName : ""someHub"",
        activities:
        [
            {
                name: ""MLActivity2"",
                description: ""Test activity description"", 
                type: ""AzureMLBatchScoring"",
                inputs: 
                [ 
                    {
                        name: ""csvBlob""
                    }
                ],
                outputs: 
                [ 
                    {
                        name: ""sasCopyBlob""
                    }
                ],
                linkedServiceName: ""mlLinkedService"",
                policy:
                {
                    concurrency: 3,
                    executionPriorityOrder: ""NewestFirst"",
                    retry: 3,
                    timeout: ""00:00:05"",
                    delay: ""00:00:01""
                },
                typeProperties:
                {
                    webServiceParameters:
                    {
                        DateTime1: ""2015-04-12T12:13:14Z"",
                        DateTime2: ""04/12/2015 12:13:14"",
                        DateTime3: ""2015-04-12T12:13:14""
                    }
                }
            }
        ]
    }
}
";

        [JsonSample(propertyBagKeys: new string[] 
            { 
                "properties.activities[0].typeProperties.parameters.DateTime1",
                "properties.activities[0].typeProperties.parameters.DateTime2",
                "properties.activities[0].typeProperties.parameters.DateTime3"
            })]
        public const string DataLakeAnalyticsActivityPipeline = @"
{
    name: ""MyPipelineName"",
    properties:
    {
        description : ""Data Lake analytics pipeline"",
        activities:
        [
            {
                name: ""DataLakeAnalyticsUSQL"",
                inputs: [ {name: ""DataLake-Table-In""} ],
                outputs: [ {name: ""DataLake-Table-Out""} ],
                linkedServiceName: ""Linked-ServiceDataLakeAnalytics"",
                type: ""DataLakeAnalyticsU-SQL"",
                typeProperties:
                {
                    script: ""CREATE DATABASE test;"",
                    degreeOfParallelism: 3,
                    priority: 100,
                    parameters:
                    {
                        DateTime1: ""2015-04-12T12:13:14Z"",
                        DateTime2: ""04/12/2015 12:13:14"",
                        DateTime3: ""2015-04-12T12:13:14""
                    }
                },
                policy:
                {
                    concurrency: 1,
                    executionPriorityOrder: ""NewestFirst"",
                    retry: 2,
                    timeout: ""01:00:00""
                }
            }
        ]
    }
}
";
    }
}