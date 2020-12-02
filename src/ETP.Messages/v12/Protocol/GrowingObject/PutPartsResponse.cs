// ------------------------------------------------------------------------------
// <auto-generated>
//    Generated by avrogen.exe, version 0.9.0.0
//    Changes to this file may cause incorrect behavior and will be lost if code
//    is regenerated
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Energistics.Etp.v12.Protocol.GrowingObject
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using Avro;
	using Avro.Specific;
	
	public partial class PutPartsResponse : ISpecificRecord
	{
		public static Schema _SCHEMA = Avro.Schema.Parse(@"{""type"":""record"",""name"":""PutPartsResponse"",""namespace"":""Energistics.Etp.v12.Protocol.GrowingObject"",""fields"":[{""name"":""success"",""type"":{""type"":""map"",""values"":""string""}}],""protocol"":""6"",""messageType"":""13"",""senderRole"":""store"",""protocolRoles"":""store,customer"",""multipartFlag"":true,""fullName"":""Energistics.Etp.v12.Protocol.GrowingObject.PutPartsResponse"",""depends"":[]}");
		private IDictionary<string,System.String> _success;
		public virtual Schema Schema
		{
			get
			{
				return PutPartsResponse._SCHEMA;
			}
		}
		public IDictionary<string,System.String> Success
		{
			get
			{
				return this._success;
			}
			set
			{
				this._success = value;
			}
		}
		public virtual object Get(int fieldPos)
		{
			switch (fieldPos)
			{
			case 0: return this._success;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Get()");
			};
		}
		public virtual void Put(int fieldPos, object fieldValue)
		{
			switch (fieldPos)
			{
			case 0: this._success = (IDictionary<string,System.String>)fieldValue; break;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Put()");
			};
		}
	}
}
