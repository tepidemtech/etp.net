// ------------------------------------------------------------------------------
// <auto-generated>
//    Generated by avrogen.exe, version 0.9.0.0
//    Changes to this file may cause incorrect behavior and will be lost if code
//    is regenerated
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Energistics.Etp.v12.Protocol.GrowingObjectNotification
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using Avro;
	using Avro.Specific;
	
	public partial class UnsolicitedPartNotifications : ISpecificRecord
	{
		public static Schema _SCHEMA = Avro.Schema.Parse("{\"type\":\"record\",\"name\":\"UnsolicitedPartNotifications\",\"namespace\":\"Energistics.E" +
				"tp.v12.Protocol.GrowingObjectNotification\",\"fields\":[{\"name\":\"subscriptions\",\"ty" +
				"pe\":{\"type\":\"array\",\"items\":{\"type\":\"record\",\"name\":\"SubscriptionInfo\",\"namespac" +
				"e\":\"Energistics.Etp.v12.Datatypes.Object\",\"fields\":[{\"name\":\"context\",\"type\":{\"t" +
				"ype\":\"record\",\"name\":\"ContextInfo\",\"namespace\":\"Energistics.Etp.v12.Datatypes.Ob" +
				"ject\",\"fields\":[{\"name\":\"uri\",\"type\":\"string\"},{\"name\":\"depth\",\"type\":\"int\"},{\"n" +
				"ame\":\"dataObjectTypes\",\"default\":[],\"type\":{\"type\":\"array\",\"items\":\"string\"}},{\"" +
				"name\":\"navigableEdges\",\"type\":{\"type\":\"enum\",\"name\":\"RelationshipKind\",\"namespac" +
				"e\":\"Energistics.Etp.v12.Datatypes.Object\",\"symbols\":[\"Primary\",\"Secondary\",\"Both" +
				"\"],\"fullName\":\"Energistics.Etp.v12.Datatypes.Object.RelationshipKind\",\"depends\":" +
				"[]}},{\"name\":\"includeSecondaryTargets\",\"default\":false,\"type\":\"boolean\"},{\"name\"" +
				":\"includeSecondarySources\",\"default\":false,\"type\":\"boolean\"}],\"fullName\":\"Energi" +
				"stics.Etp.v12.Datatypes.Object.ContextInfo\",\"depends\":[\r\n  \"Energistics.Etp.v12." +
				"Datatypes.Object.RelationshipKind\"\r\n]}},{\"name\":\"scope\",\"type\":{\"type\":\"enum\",\"n" +
				"ame\":\"ContextScopeKind\",\"namespace\":\"Energistics.Etp.v12.Datatypes.Object\",\"symb" +
				"ols\":[\"self\",\"sources\",\"targets\",\"sourcesOrSelf\",\"targetsOrSelf\"],\"fullName\":\"En" +
				"ergistics.Etp.v12.Datatypes.Object.ContextScopeKind\",\"depends\":[]}},{\"name\":\"req" +
				"uestUuid\",\"type\":{\"type\":\"fixed\",\"name\":\"Uuid\",\"namespace\":\"Energistics.Etp.v12." +
				"Datatypes\",\"size\":16,\"fullName\":\"Energistics.Etp.v12.Datatypes.Uuid\",\"depends\":[" +
				"]}},{\"name\":\"startTime\",\"type\":\"long\"},{\"name\":\"includeObjectData\",\"type\":\"boole" +
				"an\"},{\"name\":\"format\",\"default\":\"xml\",\"type\":\"string\"}],\"fullName\":\"Energistics." +
				"Etp.v12.Datatypes.Object.SubscriptionInfo\",\"depends\":[\r\n  \"Energistics.Etp.v12.D" +
				"atatypes.Object.ContextInfo\",\r\n  \"Energistics.Etp.v12.Datatypes.Object.ContextSc" +
				"opeKind\",\r\n  \"Energistics.Etp.v12.Datatypes.Uuid\"\r\n]}}}],\"protocol\":\"7\",\"message" +
				"Type\":\"9\",\"senderRole\":\"store\",\"protocolRoles\":\"store,customer\",\"multipartFlag\":" +
				"false,\"fullName\":\"Energistics.Etp.v12.Protocol.GrowingObjectNotification.Unsolic" +
				"itedPartNotifications\",\"depends\":[\r\n  \"Energistics.Etp.v12.Datatypes.Object.Subs" +
				"criptionInfo\"\r\n]}");
		private IList<Energistics.Etp.v12.Datatypes.Object.SubscriptionInfo> _subscriptions;
		public virtual Schema Schema
		{
			get
			{
				return UnsolicitedPartNotifications._SCHEMA;
			}
		}
		public IList<Energistics.Etp.v12.Datatypes.Object.SubscriptionInfo> Subscriptions
		{
			get
			{
				return this._subscriptions;
			}
			set
			{
				this._subscriptions = value;
			}
		}
		public virtual object Get(int fieldPos)
		{
			switch (fieldPos)
			{
			case 0: return this._subscriptions;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Get()");
			};
		}
		public virtual void Put(int fieldPos, object fieldValue)
		{
			switch (fieldPos)
			{
			case 0: this._subscriptions = (IList<Energistics.Etp.v12.Datatypes.Object.SubscriptionInfo>)fieldValue; break;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Put()");
			};
		}
	}
}
