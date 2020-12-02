// ------------------------------------------------------------------------------
// <auto-generated>
//    Generated by avrogen.exe, version 0.9.0.0
//    Changes to this file may cause incorrect behavior and will be lost if code
//    is regenerated
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Energistics.Etp.v12.Protocol.StoreQuery
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using Avro;
	using Avro.Specific;
	
	public partial class Chunk : ISpecificRecord
	{
		public static Schema _SCHEMA = Avro.Schema.Parse(@"{""type"":""record"",""name"":""Chunk"",""namespace"":""Energistics.Etp.v12.Protocol.StoreQuery"",""fields"":[{""name"":""blobId"",""type"":{""type"":""fixed"",""name"":""Uuid"",""namespace"":""Energistics.Etp.v12.Datatypes"",""size"":16,""fullName"":""Energistics.Etp.v12.Datatypes.Uuid"",""depends"":[]}},{""name"":""data"",""type"":""bytes""},{""name"":""final"",""type"":""boolean""}],""protocol"":""14"",""messageType"":""3"",""senderRole"":""store"",""protocolRoles"":""store,customer"",""multipartFlag"":true,""fullName"":""Energistics.Etp.v12.Protocol.StoreQuery.Chunk"",""depends"":[
  ""Energistics.Etp.v12.Datatypes.Uuid""
]}");
		private Energistics.Etp.v12.Datatypes.Uuid _blobId;
		private byte[] _data;
		private bool _final;
		public virtual Schema Schema
		{
			get
			{
				return Chunk._SCHEMA;
			}
		}
		public Energistics.Etp.v12.Datatypes.Uuid BlobId
		{
			get
			{
				return this._blobId;
			}
			set
			{
				this._blobId = value;
			}
		}
		public byte[] Data
		{
			get
			{
				return this._data;
			}
			set
			{
				this._data = value;
			}
		}
		public bool Final
		{
			get
			{
				return this._final;
			}
			set
			{
				this._final = value;
			}
		}
		public virtual object Get(int fieldPos)
		{
			switch (fieldPos)
			{
			case 0: return this._blobId;
			case 1: return this._data;
			case 2: return this._final;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Get()");
			};
		}
		public virtual void Put(int fieldPos, object fieldValue)
		{
			switch (fieldPos)
			{
			case 0: this._blobId = (Energistics.Etp.v12.Datatypes.Uuid)fieldValue; break;
			case 1: this._data = (System.Byte[])fieldValue; break;
			case 2: this._final = (System.Boolean)fieldValue; break;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Put()");
			};
		}
	}
}
