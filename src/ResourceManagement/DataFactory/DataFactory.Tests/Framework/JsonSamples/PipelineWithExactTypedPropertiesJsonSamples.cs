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
    public class PipelineWithExactTypedPropertiesJsonSamples : JsonSampleCollection<PipelineWithExactTypedPropertiesJsonSamples>
    {
        [JsonSample(propertyBagKeys: new string[] 
            { 
                "properties.activities[0].typeProperties.extendedProperties.DateTime1",
                "properties.activities[0].typeProperties.extendedProperties.DateTime2",
                "properties.activities[0].typeProperties.extendedProperties.DateTime3",
                "properties.activities[0].typeProperties.extendedProperties.DateTime4",
            }
        )]
        public const string DotNetActivityPipeline = @"
{
    name: ""DataPipeline_SamplePipeline"",
    properties:
    {
        description : ""Sample Data Pipeline"",
        hubName: ""MyHDIHub"",
        activities:
        [
            {
                name: ""DotNetActivity"",
                inputs: [ {name: ""DA_WikipediaClickEvents""} ],
                outputs: [ {name: ""DA_CuratedWikiData""} ],
                linkedServiceName: ""HDILinkedService"",
                type: ""DotNetActivity"",
                typeProperties:
                {
			        assemblyName: ""mycode.dll"",
                    entryPoint: ""myclassname"",
                    packageLinkedService: ""imagestoreLinkedService"",
                    packageFile: ""images/assembly.zip"",
                    extendedProperties:
                    {
                        DateTime1: ""2015-04-12T12:13:14Z"",
                        DateTime2: ""2015-04-12T12:13:14-09:00"",
                        DateTime3: ""04/12/2015 12:13:14"",
                        DateTime4: ""12/04/2015 12:13:14""
                    }
                },
                policy:
                {
                    concurrency: 1,
                    executionPriorityOrder: ""NewestFirst"",
                    retry: 2,
                    timeout: ""01:00:00""
                },
                scheduler:
                {
                    offset: ""01:00:00"",
                    interval: 1,
                    anchorDateTime: ""2014-02-27T12:00:00Z"",
                    frequency: ""Hour""
                }
            },
        ]
    }
}
";

        [JsonSample(propertyBagKeys: new string[] 
            { 
                "properties.activities[0].typeProperties.defines.DateTime1",
                "properties.activities[0].typeProperties.defines.DateTime2",
                "properties.activities[0].typeProperties.defines.DateTime3",
                "properties.activities[0].typeProperties.defines.DateTime4"
            }
        )]
        public const string HDInsightPipeline = @"
{
    name: ""My HDInsight pipeline"",
    properties: 
    {
        description : ""HDInsight pipeline description"",
        hubName: ""MyHDIHub"",
        activities:
        [
            {
                name: ""TestActivity"",
                description: ""Test activity description"", 
                type: ""HDInsightHive"",
                typeProperties:
                {
                    script: ""SELECT 1"",
                    defines:
                    {
                        DateTime1: ""2015-04-12T12:13:14Z"",
                        DateTime2: ""2015-04-12T12:13:14-09:00"",
                        DateTime3: ""04/12/2015 12:13:14"",
                        DateTime4: ""12/04/2015 12:13:14""
                    },
                    storageLinkedServices:
                    [
                        ""SA1"",
                        ""SA2""
                    ],
                    arguments: [],
                    getDebugInfo : ""Failure""
                },
                linkedServiceName: ""MyLinkedServiceName""
            }
        ],
        pipelineMode: ""Scheduled"",
        expirationTime: ""5.00:00:00"",
        start: ""2001-01-01"",
        end: ""2001-01-01"",
        isPaused: false,
        runtimeInfo: 
        {
            deploymentTime: ""2002-01-01""
        }
    }
}
";
    }
}