﻿//----------------------------------------------------------------------- 
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

using System.Collections.Generic;

namespace Energistics.Etp.Common.Datatypes.ChannelData
{
    public interface IChannelRangeInfo : Avro.Specific.ISpecificRecord
    {
        IList<long> ChannelIds { get; set; }

        object StartIndex { get; set; }

        object EndIndex { get; set; }

        string Uom { get; set; }

        string DepthDatum { get; set; }
    }
}