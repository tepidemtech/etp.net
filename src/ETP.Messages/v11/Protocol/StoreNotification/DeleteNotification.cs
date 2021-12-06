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

namespace Energistics.Etp.v11.Protocol.StoreNotification
{
    [AvroNamedType("DeleteNotification", "Energistics.Protocol.StoreNotification")]
    public partial class DeleteNotification
    {
        public static string CanonicalSchema { get; } = "{\"type\":\"record\",\"name\":\"Energistics.Protocol.StoreNotification.DeleteNotification\",\"fields\":[{\"name\":\"delete\",\"type\":{\"type\":\"record\",\"name\":\"Energistics.Datatypes.Object.ObjectChange\",\"fields\":[{\"name\":\"changeType\",\"type\":{\"name\":\"Energistics.Datatypes.Object.ObjectChangeTypes\",\"type\":\"enum\",\"symbols\":[\"Upsert\",\"Delete\"]}},{\"name\":\"changeTime\",\"type\":\"long\"},{\"name\":\"dataObject\",\"type\":{\"type\":\"record\",\"name\":\"Energistics.Datatypes.Object.DataObject\",\"fields\":[{\"name\":\"resource\",\"type\":{\"type\":\"record\",\"name\":\"Energistics.Datatypes.Object.Resource\",\"fields\":[{\"name\":\"uri\",\"type\":\"string\"},{\"name\":\"contentType\",\"type\":\"string\"},{\"name\":\"name\",\"type\":\"string\"},{\"name\":\"channelSubscribable\",\"type\":\"boolean\"},{\"name\":\"customData\",\"type\":{\"type\":\"map\",\"values\":\"string\"}},{\"name\":\"resourceType\",\"type\":\"string\"},{\"name\":\"hasChildren\",\"type\":\"int\"},{\"name\":\"uuid\",\"type\":[\"null\",\"string\"]},{\"name\":\"lastChanged\",\"type\":\"long\"},{\"name\":\"objectNotifiable\",\"type\":\"boolean\"}]}},{\"name\":\"contentEncoding\",\"type\":\"string\"},{\"name\":\"data\",\"type\":\"bytes\"}]}}]}}]}";
        [AvroRecordField("delete")]
        public Energistics.Etp.v11.Datatypes.Object.ObjectChange Delete { get; set; }
    }
}
