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

namespace Energistics.Avro.Encoding
{
    /// <summary>
    /// An interface for decoding Avro primitive data
    /// </summary>
    public interface IPrimitiveDecoder : System.IDisposable
    {
        void DecodeNull();
        T DecodeNullClass<T>() where T : class;
        T? DecodeNullStruct<T>() where T : struct;
        bool DecodeBoolean();
        int DecodeInt();
        long DecodeLong();
        float DecodeFloat();
        double DecodeDouble();
        string DecodeString();
        byte[] DecodeBytes();
    }
}
