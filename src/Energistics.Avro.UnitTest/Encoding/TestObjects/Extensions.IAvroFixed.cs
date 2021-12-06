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

using Energistics.Avro;
using Energistics.Avro.Encoding;

namespace Energistics.Avro.Encoding.TestObjects
{
    public partial class TestFixed : IAvroFixed
    {
        long IAvroFixed.ByteCount => ByteCount;
        byte[] IAvroFixed.Bytes
        {
            get => Bytes;
            set => Bytes = value;
        }
        string IAvroObject.AvroTypeName => "Energistics.Avro.Encoding.TestObjects.TestFixed";
        void IAvroObject.Encode(IAvroEncoder encoder) => encoder.EncodeFixed(4L, ((IAvroFixed)this).Bytes);
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            ((IAvroFixed)this).Bytes = decoder.DecodeFixed(4L);
        }
    }
}
