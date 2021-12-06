﻿//-----------------------------------------------------------------------
// ETP DevKit, 1.2
// 
// Copyright 2021 Energistics
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//     http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//-----------------------------------------------------------------------
// 
//-----------------------------------------------------------------------
// This code has been automatically generated.
// Changes will be lost the next time it is regenerated.
//-----------------------------------------------------------------------

using System;
using System.Collections.Generic;
using Energistics.Avro;

namespace Energistics.Etp.v11.Protocol.ChannelStreaming
{
    [AvroNamedType("ChannelMetadata", "Energistics.Protocol.ChannelStreaming")]
    public partial class ChannelMetadata
    {
        public static string CanonicalSchema { get; } = "{\"type\":\"record\",\"name\":\"Energistics.Protocol.ChannelStreaming.ChannelMetadata\",\"fields\":[{\"name\":\"channels\",\"type\":{\"type\":\"array\",\"items\":{\"type\":\"record\",\"name\":\"Energistics.Datatypes.ChannelData.ChannelMetadataRecord\",\"fields\":[{\"name\":\"channelUri\",\"type\":\"string\"},{\"name\":\"channelId\",\"type\":\"long\"},{\"name\":\"indexes\",\"type\":{\"type\":\"array\",\"items\":{\"type\":\"record\",\"name\":\"Energistics.Datatypes.ChannelData.IndexMetadataRecord\",\"fields\":[{\"name\":\"indexType\",\"type\":{\"name\":\"Energistics.Datatypes.ChannelData.ChannelIndexTypes\",\"type\":\"enum\",\"symbols\":[\"Time\",\"Depth\"]}},{\"name\":\"uom\",\"type\":\"string\"},{\"name\":\"depthDatum\",\"type\":[\"null\",\"string\"]},{\"name\":\"direction\",\"type\":{\"name\":\"Energistics.Datatypes.ChannelData.IndexDirections\",\"type\":\"enum\",\"symbols\":[\"Increasing\",\"Decreasing\"]}},{\"name\":\"mnemonic\",\"type\":[\"null\",\"string\"]},{\"name\":\"description\",\"type\":[\"null\",\"string\"]},{\"name\":\"uri\",\"type\":[\"null\",\"string\"]},{\"name\":\"customData\",\"type\":{\"type\":\"map\",\"values\":{\"type\":\"record\",\"name\":\"Energistics.Datatypes.DataValue\",\"fields\":[{\"name\":\"item\",\"type\":[\"null\",\"double\",\"float\",\"int\",\"long\",\"string\",{\"type\":\"record\",\"name\":\"Energistics.Datatypes.ArrayOfDouble\",\"fields\":[{\"name\":\"values\",\"type\":{\"type\":\"array\",\"items\":\"double\"}}]},\"boolean\",\"bytes\"]}]}}},{\"name\":\"scale\",\"type\":\"int\"},{\"name\":\"timeDatum\",\"type\":[\"null\",\"string\"]}]}}},{\"name\":\"channelName\",\"type\":\"string\"},{\"name\":\"dataType\",\"type\":\"string\"},{\"name\":\"uom\",\"type\":\"string\"},{\"name\":\"startIndex\",\"type\":[\"null\",\"long\"]},{\"name\":\"endIndex\",\"type\":[\"null\",\"long\"]},{\"name\":\"description\",\"type\":\"string\"},{\"name\":\"status\",\"type\":{\"name\":\"Energistics.Datatypes.ChannelData.ChannelStatuses\",\"type\":\"enum\",\"symbols\":[\"Active\",\"Inactive\",\"Closed\"]}},{\"name\":\"contentType\",\"type\":[\"null\",\"string\"]},{\"name\":\"source\",\"type\":\"string\"},{\"name\":\"measureClass\",\"type\":\"string\"},{\"name\":\"uuid\",\"type\":[\"null\",\"string\"]},{\"name\":\"customData\",\"type\":{\"type\":\"map\",\"values\":\"Energistics.Datatypes.DataValue\"}},{\"name\":\"domainObject\",\"type\":[\"null\",{\"type\":\"record\",\"name\":\"Energistics.Datatypes.Object.DataObject\",\"fields\":[{\"name\":\"resource\",\"type\":{\"type\":\"record\",\"name\":\"Energistics.Datatypes.Object.Resource\",\"fields\":[{\"name\":\"uri\",\"type\":\"string\"},{\"name\":\"contentType\",\"type\":\"string\"},{\"name\":\"name\",\"type\":\"string\"},{\"name\":\"channelSubscribable\",\"type\":\"boolean\"},{\"name\":\"customData\",\"type\":{\"type\":\"map\",\"values\":\"string\"}},{\"name\":\"resourceType\",\"type\":\"string\"},{\"name\":\"hasChildren\",\"type\":\"int\"},{\"name\":\"uuid\",\"type\":[\"null\",\"string\"]},{\"name\":\"lastChanged\",\"type\":\"long\"},{\"name\":\"objectNotifiable\",\"type\":\"boolean\"}]}},{\"name\":\"contentEncoding\",\"type\":\"string\"},{\"name\":\"data\",\"type\":\"bytes\"}]}]}]}}}]}";
        [AvroRecordField("channels")]
        public IList<Energistics.Etp.v11.Datatypes.ChannelData.ChannelMetadataRecord> Channels { get; set; }
    }
}
