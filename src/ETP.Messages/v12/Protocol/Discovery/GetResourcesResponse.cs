// ------------------------------------------------------------------------------
// <auto-generated>
//    Generated by avrogen.exe, version 0.9.0.0
//    Changes to this file may cause incorrect behavior and will be lost if code
//    is regenerated
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Energistics.Etp.v12.Protocol.Discovery
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using Avro;
	using Avro.Specific;
	
	public partial class GetResourcesResponse : ISpecificRecord
	{
		public static Schema _SCHEMA = Avro.Schema.Parse(@"{""type"":""record"",""name"":""GetResourcesResponse"",""namespace"":""Energistics.Etp.v12.Protocol.Discovery"",""fields"":[{""name"":""resources"",""type"":{""type"":""array"",""items"":{""type"":""record"",""name"":""Resource"",""namespace"":""Energistics.Etp.v12.Datatypes.Object"",""fields"":[{""name"":""uri"",""type"":""string""},{""name"":""contentType"",""type"":""string""},{""name"":""name"",""type"":""string""},{""name"":""objectNotifiable"",""default"":true,""type"":""boolean""},{""name"":""resourceType"",""type"":{""type"":""enum"",""name"":""ResourceKind"",""namespace"":""Energistics.Etp.v12.Datatypes.Object"",""symbols"":[""DataObject"",""Folder"",""UriProtocol"",""DataSpace""],""fullName"":""Energistics.Etp.v12.Datatypes.Object.ResourceKind"",""depends"":[]}},{""name"":""sourceCount"",""default"":null,""type"":[""null"",""int""]},{""name"":""targetCount"",""default"":null,""type"":[""null"",""int""]},{""name"":""contentCount"",""default"":null,""type"":[""null"",""int""]},{""name"":""lastChanged"",""type"":[""null"",""long""]},{""name"":""customData"",""type"":{""type"":""map"",""values"":""string""}}],""fullName"":""Energistics.Etp.v12.Datatypes.Object.Resource"",""depends"":[
  ""Energistics.Etp.v12.Datatypes.Object.ResourceKind""
]}}}],""protocol"":""3"",""messageType"":""4"",""senderRole"":""store"",""protocolRoles"":""store,customer"",""multipartFlag"":true,""fullName"":""Energistics.Etp.v12.Protocol.Discovery.GetResourcesResponse"",""depends"":[
  ""Energistics.Etp.v12.Datatypes.Object.Resource""
]}");
		private IList<Energistics.Etp.v12.Datatypes.Object.Resource> _resources;
		public virtual Schema Schema
		{
			get
			{
				return GetResourcesResponse._SCHEMA;
			}
		}
		public IList<Energistics.Etp.v12.Datatypes.Object.Resource> Resources
		{
			get
			{
				return this._resources;
			}
			set
			{
				this._resources = value;
			}
		}
		public virtual object Get(int fieldPos)
		{
			switch (fieldPos)
			{
			case 0: return this._resources;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Get()");
			};
		}
		public virtual void Put(int fieldPos, object fieldValue)
		{
			switch (fieldPos)
			{
			case 0: this._resources = (IList<Energistics.Etp.v12.Datatypes.Object.Resource>)fieldValue; break;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Put()");
			};
		}
	}
}
