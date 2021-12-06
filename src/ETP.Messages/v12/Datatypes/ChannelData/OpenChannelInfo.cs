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

namespace Energistics.Etp.v12.Datatypes.ChannelData
{
    [AvroNamedType("OpenChannelInfo", "Energistics.Etp.v12.Datatypes.ChannelData")]
    public partial class OpenChannelInfo
    {
        public static string CanonicalSchema { get; } = "{\"type\":\"record\",\"name\":\"Energistics.Etp.v12.Datatypes.ChannelData.OpenChannelInfo\",\"fields\":[{\"name\":\"metadata\",\"type\":{\"type\":\"record\",\"name\":\"Energistics.Etp.v12.Datatypes.ChannelData.ChannelMetadataRecord\",\"fields\":[{\"name\":\"uri\",\"type\":\"string\"},{\"name\":\"id\",\"type\":\"long\"},{\"name\":\"indexes\",\"type\":{\"type\":\"array\",\"items\":{\"type\":\"record\",\"name\":\"Energistics.Etp.v12.Datatypes.ChannelData.IndexMetadataRecord\",\"fields\":[{\"name\":\"indexKind\",\"type\":{\"name\":\"Energistics.Etp.v12.Datatypes.ChannelData.ChannelIndexKind\",\"type\":\"enum\",\"symbols\":[\"DateTime\",\"ElapsedTime\",\"MeasuredDepth\",\"TrueVerticalDepth\",\"PassIndexedDepth\",\"Pressure\",\"Temperature\",\"Scalar\"]}},{\"name\":\"interval\",\"type\":{\"type\":\"record\",\"name\":\"Energistics.Etp.v12.Datatypes.Object.IndexInterval\",\"fields\":[{\"name\":\"startIndex\",\"type\":{\"type\":\"record\",\"name\":\"Energistics.Etp.v12.Datatypes.IndexValue\",\"fields\":[{\"name\":\"item\",\"type\":[\"null\",\"long\",\"double\",{\"type\":\"record\",\"name\":\"Energistics.Etp.v12.Datatypes.ChannelData.PassIndexedDepth\",\"fields\":[{\"name\":\"pass\",\"type\":\"long\"},{\"name\":\"direction\",\"type\":{\"name\":\"Energistics.Etp.v12.Datatypes.ChannelData.PassDirection\",\"type\":\"enum\",\"symbols\":[\"Up\",\"HoldingSteady\",\"Down\"]}},{\"name\":\"depth\",\"type\":\"double\"}]}]}]}},{\"name\":\"endIndex\",\"type\":\"Energistics.Etp.v12.Datatypes.IndexValue\"},{\"name\":\"uom\",\"type\":\"string\"},{\"name\":\"depthDatum\",\"type\":\"string\"}]}},{\"name\":\"direction\",\"type\":{\"name\":\"Energistics.Etp.v12.Datatypes.ChannelData.IndexDirection\",\"type\":\"enum\",\"symbols\":[\"Increasing\",\"Decreasing\",\"Unordered\"]}},{\"name\":\"name\",\"type\":\"string\"},{\"name\":\"uom\",\"type\":\"string\"},{\"name\":\"depthDatum\",\"type\":\"string\"},{\"name\":\"indexPropertyKindUri\",\"type\":\"string\"},{\"name\":\"filterable\",\"type\":\"boolean\"}]}}},{\"name\":\"channelName\",\"type\":\"string\"},{\"name\":\"dataKind\",\"type\":{\"name\":\"Energistics.Etp.v12.Datatypes.ChannelData.ChannelDataKind\",\"type\":\"enum\",\"symbols\":[\"DateTime\",\"ElapsedTime\",\"MeasuredDepth\",\"PassIndexedDepth\",\"TrueVerticalDepth\",\"typeBoolean\",\"typeInt\",\"typeLong\",\"typeFloat\",\"typeDouble\",\"typeString\",\"typeBytes\"]}},{\"name\":\"uom\",\"type\":\"string\"},{\"name\":\"depthDatum\",\"type\":\"string\"},{\"name\":\"channelClassUri\",\"type\":\"string\"},{\"name\":\"status\",\"type\":{\"name\":\"Energistics.Etp.v12.Datatypes.Object.ActiveStatusKind\",\"type\":\"enum\",\"symbols\":[\"Active\",\"Inactive\"]}},{\"name\":\"source\",\"type\":\"string\"},{\"name\":\"axisVectorLengths\",\"type\":{\"type\":\"array\",\"items\":\"int\"}},{\"name\":\"attributeMetadata\",\"type\":{\"type\":\"array\",\"items\":{\"type\":\"record\",\"name\":\"Energistics.Etp.v12.Datatypes.AttributeMetadataRecord\",\"fields\":[{\"name\":\"attributeId\",\"type\":\"int\"},{\"name\":\"attributeName\",\"type\":\"string\"},{\"name\":\"dataKind\",\"type\":\"Energistics.Etp.v12.Datatypes.ChannelData.ChannelDataKind\"},{\"name\":\"uom\",\"type\":\"string\"},{\"name\":\"depthDatum\",\"type\":\"string\"},{\"name\":\"attributePropertyKindUri\",\"type\":\"string\"},{\"name\":\"axisVectorLengths\",\"type\":{\"type\":\"array\",\"items\":\"int\"}}]}}},{\"name\":\"customData\",\"type\":{\"type\":\"map\",\"values\":{\"type\":\"record\",\"name\":\"Energistics.Etp.v12.Datatypes.DataValue\",\"fields\":[{\"name\":\"item\",\"type\":[\"null\",\"boolean\",\"int\",\"long\",\"float\",\"double\",\"string\",{\"type\":\"record\",\"name\":\"Energistics.Etp.v12.Datatypes.ArrayOfBoolean\",\"fields\":[{\"name\":\"values\",\"type\":{\"type\":\"array\",\"items\":\"boolean\"}}]},{\"type\":\"record\",\"name\":\"Energistics.Etp.v12.Datatypes.ArrayOfNullableBoolean\",\"fields\":[{\"name\":\"values\",\"type\":{\"type\":\"array\",\"items\":[\"null\",\"boolean\"]}}]},{\"type\":\"record\",\"name\":\"Energistics.Etp.v12.Datatypes.ArrayOfInt\",\"fields\":[{\"name\":\"values\",\"type\":{\"type\":\"array\",\"items\":\"int\"}}]},{\"type\":\"record\",\"name\":\"Energistics.Etp.v12.Datatypes.ArrayOfNullableInt\",\"fields\":[{\"name\":\"values\",\"type\":{\"type\":\"array\",\"items\":[\"null\",\"int\"]}}]},{\"type\":\"record\",\"name\":\"Energistics.Etp.v12.Datatypes.ArrayOfLong\",\"fields\":[{\"name\":\"values\",\"type\":{\"type\":\"array\",\"items\":\"long\"}}]},{\"type\":\"record\",\"name\":\"Energistics.Etp.v12.Datatypes.ArrayOfNullableLong\",\"fields\":[{\"name\":\"values\",\"type\":{\"type\":\"array\",\"items\":[\"null\",\"long\"]}}]},{\"type\":\"record\",\"name\":\"Energistics.Etp.v12.Datatypes.ArrayOfFloat\",\"fields\":[{\"name\":\"values\",\"type\":{\"type\":\"array\",\"items\":\"float\"}}]},{\"type\":\"record\",\"name\":\"Energistics.Etp.v12.Datatypes.ArrayOfDouble\",\"fields\":[{\"name\":\"values\",\"type\":{\"type\":\"array\",\"items\":\"double\"}}]},{\"type\":\"record\",\"name\":\"Energistics.Etp.v12.Datatypes.ArrayOfString\",\"fields\":[{\"name\":\"values\",\"type\":{\"type\":\"array\",\"items\":\"string\"}}]},{\"type\":\"record\",\"name\":\"Energistics.Etp.v12.Datatypes.ArrayOfBytes\",\"fields\":[{\"name\":\"values\",\"type\":{\"type\":\"array\",\"items\":\"bytes\"}}]},\"bytes\",{\"type\":\"record\",\"name\":\"Energistics.Etp.v12.Datatypes.AnySparseArray\",\"fields\":[{\"name\":\"slices\",\"type\":{\"type\":\"array\",\"items\":{\"type\":\"record\",\"name\":\"Energistics.Etp.v12.Datatypes.AnySubarray\",\"fields\":[{\"name\":\"start\",\"type\":\"long\"},{\"name\":\"slice\",\"type\":{\"type\":\"record\",\"name\":\"Energistics.Etp.v12.Datatypes.AnyArray\",\"fields\":[{\"name\":\"item\",\"type\":[\"Energistics.Etp.v12.Datatypes.ArrayOfBoolean\",\"Energistics.Etp.v12.Datatypes.ArrayOfInt\",\"Energistics.Etp.v12.Datatypes.ArrayOfLong\",\"Energistics.Etp.v12.Datatypes.ArrayOfFloat\",\"Energistics.Etp.v12.Datatypes.ArrayOfDouble\",\"Energistics.Etp.v12.Datatypes.ArrayOfString\",\"bytes\"]}]}}]}}}]}]}]}}}]}},{\"name\":\"preferRealtime\",\"type\":\"boolean\"},{\"name\":\"dataChanges\",\"type\":\"boolean\"}]}";
        [AvroRecordField("metadata")]
        public Energistics.Etp.v12.Datatypes.ChannelData.ChannelMetadataRecord Metadata { get; set; }
        [AvroRecordField("preferRealtime")]
        public bool PreferRealtime { get; set; }
        [AvroRecordField("dataChanges")]
        public bool DataChanges { get; set; }
    }
}
