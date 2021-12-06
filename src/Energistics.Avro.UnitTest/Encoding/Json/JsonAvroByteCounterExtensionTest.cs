//----------------------------------------------------------------------- 
// ETP DevKit, 1.2
//
// Copyright 2019 Energistics
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

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Energistics.Avro.Encoding.Json
{
    [TestClass]
    public class JsonAvroByteCounterExtensionTest : AvroEncoderExtensionTest
    {
        protected override (object expected, object actual) Encode(TestCase testCase, Action<IAvroEncoder> action)
        {
            var encoder = new JsonAvroByteCounter();
            action(encoder);
            return (testCase.JsonByteCount, encoder.ByteCount);
        }
    }
}
