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

namespace Energistics.CodeGen.Avro.Code.TypeInfos.LogicalTypeInfos
{
    public class TimestampMillisInfo : LogicalInfo
    {
        public TimestampMillisInfo(TypeInfo baseTypeInfo, string avroName, string avroNamespace, string name, string @namespace, string encodingStyle, bool isStruct)
            : base(baseTypeInfo, avroName, avroNamespace, name, @namespace, "timestamp-millis", "TimestampMillis", encodingStyle, isStruct)
        {
        }

        private TimestampMillisInfo(TypeInfo baseTypeInfo, TypeInfo defaultBaseTypeInfo, string name, string @namespace, string encodingStyle, bool isStruct)
            : this(baseTypeInfo ?? defaultBaseTypeInfo, (baseTypeInfo ?? defaultBaseTypeInfo)?.AvroName, (baseTypeInfo ?? defaultBaseTypeInfo)?.AvroNamespace, name, @namespace, encodingStyle, isStruct)
        {
        }

        public static TimestampMillisInfo TimestampMillisDateTimeAsLong(TypeInfo baseTypeInfo = null) => new TimestampMillisInfo(baseTypeInfo, PrimitiveInfo.Long, "DateTime", "System", "Long", true);
        public static TimestampMillisInfo TimestampMillisDateTimeOffsetAsLong(TypeInfo baseTypeInfo = null) => new TimestampMillisInfo(baseTypeInfo, PrimitiveInfo.Long, "DateTimeOffset", "System", "Long", true);
    }
}
