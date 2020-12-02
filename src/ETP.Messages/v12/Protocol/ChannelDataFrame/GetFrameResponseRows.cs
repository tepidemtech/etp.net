// ------------------------------------------------------------------------------
// <auto-generated>
//    Generated by avrogen.exe, version 0.9.0.0
//    Changes to this file may cause incorrect behavior and will be lost if code
//    is regenerated
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Energistics.Etp.v12.Protocol.ChannelDataFrame
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using Avro;
	using Avro.Specific;
	
	public partial class GetFrameResponseRows : ISpecificRecord
	{
		public static Schema _SCHEMA = Avro.Schema.Parse("{\"type\":\"record\",\"name\":\"GetFrameResponseRows\",\"namespace\":\"Energistics.Etp.v12.P" +
				"rotocol.ChannelDataFrame\",\"fields\":[{\"name\":\"frame\",\"type\":{\"type\":\"array\",\"item" +
				"s\":{\"type\":\"record\",\"name\":\"FrameRow\",\"namespace\":\"Energistics.Etp.v12.Datatypes" +
				".ChannelData\",\"fields\":[{\"name\":\"indexes\",\"type\":{\"type\":\"array\",\"items\":{\"type\"" +
				":\"record\",\"name\":\"IndexValue\",\"namespace\":\"Energistics.Etp.v12.Datatypes\",\"field" +
				"s\":[{\"name\":\"item\",\"type\":[\"null\",\"long\",\"double\"]}],\"fullName\":\"Energistics.Etp" +
				".v12.Datatypes.IndexValue\",\"depends\":[]}}},{\"name\":\"points\",\"type\":{\"type\":\"arra" +
				"y\",\"items\":{\"type\":\"record\",\"name\":\"FramePoint\",\"namespace\":\"Energistics.Etp.v12" +
				".Datatypes.ChannelData\",\"fields\":[{\"name\":\"value\",\"type\":{\"type\":\"record\",\"name\"" +
				":\"DataValue\",\"namespace\":\"Energistics.Etp.v12.Datatypes\",\"fields\":[{\"name\":\"item" +
				"\",\"type\":[\"null\",\"boolean\",\"int\",\"long\",\"float\",\"double\",\"string\",{\"type\":\"recor" +
				"d\",\"name\":\"ArrayOfBoolean\",\"namespace\":\"Energistics.Etp.v12.Datatypes\",\"fields\":" +
				"[{\"name\":\"values\",\"type\":{\"type\":\"array\",\"items\":\"boolean\"}}],\"fullName\":\"Energi" +
				"stics.Etp.v12.Datatypes.ArrayOfBoolean\",\"depends\":[]},{\"type\":\"record\",\"name\":\"A" +
				"rrayOfNullableBoolean\",\"namespace\":\"Energistics.Etp.v12.Datatypes\",\"fields\":[{\"n" +
				"ame\":\"values\",\"type\":{\"type\":\"array\",\"items\":[\"null\",\"boolean\"]}}],\"fullName\":\"E" +
				"nergistics.Etp.v12.Datatypes.ArrayOfNullableBoolean\",\"depends\":[]},{\"type\":\"reco" +
				"rd\",\"name\":\"ArrayOfInt\",\"namespace\":\"Energistics.Etp.v12.Datatypes\",\"fields\":[{\"" +
				"name\":\"values\",\"type\":{\"type\":\"array\",\"items\":\"int\"}}],\"fullName\":\"Energistics.E" +
				"tp.v12.Datatypes.ArrayOfInt\",\"depends\":[]},{\"type\":\"record\",\"name\":\"ArrayOfNulla" +
				"bleInt\",\"namespace\":\"Energistics.Etp.v12.Datatypes\",\"fields\":[{\"name\":\"values\",\"" +
				"type\":{\"type\":\"array\",\"items\":[\"null\",\"int\"]}}],\"fullName\":\"Energistics.Etp.v12." +
				"Datatypes.ArrayOfNullableInt\",\"depends\":[]},{\"type\":\"record\",\"name\":\"ArrayOfLong" +
				"\",\"namespace\":\"Energistics.Etp.v12.Datatypes\",\"fields\":[{\"name\":\"values\",\"type\":" +
				"{\"type\":\"array\",\"items\":\"long\"}}],\"fullName\":\"Energistics.Etp.v12.Datatypes.Arra" +
				"yOfLong\",\"depends\":[]},{\"type\":\"record\",\"name\":\"ArrayOfNullableLong\",\"namespace\"" +
				":\"Energistics.Etp.v12.Datatypes\",\"fields\":[{\"name\":\"values\",\"type\":{\"type\":\"arra" +
				"y\",\"items\":[\"null\",\"long\"]}}],\"fullName\":\"Energistics.Etp.v12.Datatypes.ArrayOfN" +
				"ullableLong\",\"depends\":[]},{\"type\":\"record\",\"name\":\"ArrayOfFloat\",\"namespace\":\"E" +
				"nergistics.Etp.v12.Datatypes\",\"fields\":[{\"name\":\"values\",\"type\":{\"type\":\"array\"," +
				"\"items\":\"float\"}}],\"fullName\":\"Energistics.Etp.v12.Datatypes.ArrayOfFloat\",\"depe" +
				"nds\":[]},{\"type\":\"record\",\"name\":\"ArrayOfDouble\",\"namespace\":\"Energistics.Etp.v1" +
				"2.Datatypes\",\"fields\":[{\"name\":\"values\",\"type\":{\"type\":\"array\",\"items\":\"double\"}" +
				"}],\"fullName\":\"Energistics.Etp.v12.Datatypes.ArrayOfDouble\",\"depends\":[]},{\"type" +
				"\":\"record\",\"name\":\"ArrayOfString\",\"namespace\":\"Energistics.Etp.v12.Datatypes\",\"f" +
				"ields\":[{\"name\":\"values\",\"type\":{\"type\":\"array\",\"items\":\"string\"}}],\"fullName\":\"" +
				"Energistics.Etp.v12.Datatypes.ArrayOfString\",\"depends\":[]},\"bytes\",{\"type\":\"reco" +
				"rd\",\"name\":\"AnySparseArray\",\"namespace\":\"Energistics.Etp.v12.Datatypes\",\"fields\"" +
				":[{\"name\":\"slices\",\"type\":{\"type\":\"array\",\"items\":{\"type\":\"record\",\"name\":\"AnySu" +
				"barray\",\"namespace\":\"Energistics.Etp.v12.Datatypes\",\"fields\":[{\"name\":\"start\",\"t" +
				"ype\":\"long\"},{\"name\":\"slice\",\"type\":{\"type\":\"record\",\"name\":\"AnyArray\",\"namespac" +
				"e\":\"Energistics.Etp.v12.Datatypes\",\"fields\":[{\"name\":\"item\",\"type\":[\"ArrayOfBool" +
				"ean\",\"ArrayOfInt\",\"ArrayOfLong\",\"ArrayOfFloat\",\"ArrayOfDouble\",\"ArrayOfString\",\"" +
				"bytes\"]}],\"fullName\":\"Energistics.Etp.v12.Datatypes.AnyArray\",\"depends\":[\r\n  \"En" +
				"ergistics.Etp.v12.Datatypes.ArrayOfBoolean\",\r\n  \"Energistics.Etp.v12.Datatypes.A" +
				"rrayOfInt\",\r\n  \"Energistics.Etp.v12.Datatypes.ArrayOfLong\",\r\n  \"Energistics.Etp." +
				"v12.Datatypes.ArrayOfFloat\",\r\n  \"Energistics.Etp.v12.Datatypes.ArrayOfDouble\",\r\n" +
				"  \"Energistics.Etp.v12.Datatypes.ArrayOfString\"\r\n]}}],\"fullName\":\"Energistics.Et" +
				"p.v12.Datatypes.AnySubarray\",\"depends\":[\r\n  \"Energistics.Etp.v12.Datatypes.AnyAr" +
				"ray\"\r\n]}}}],\"fullName\":\"Energistics.Etp.v12.Datatypes.AnySparseArray\",\"depends\":" +
				"[\r\n  \"Energistics.Etp.v12.Datatypes.AnySubarray\"\r\n]}]}],\"fullName\":\"Energistics." +
				"Etp.v12.Datatypes.DataValue\",\"depends\":[\r\n  \"Energistics.Etp.v12.Datatypes.Array" +
				"OfBoolean\",\r\n  \"Energistics.Etp.v12.Datatypes.ArrayOfNullableBoolean\",\r\n  \"Energ" +
				"istics.Etp.v12.Datatypes.ArrayOfInt\",\r\n  \"Energistics.Etp.v12.Datatypes.ArrayOfN" +
				"ullableInt\",\r\n  \"Energistics.Etp.v12.Datatypes.ArrayOfLong\",\r\n  \"Energistics.Etp" +
				".v12.Datatypes.ArrayOfNullableLong\",\r\n  \"Energistics.Etp.v12.Datatypes.ArrayOfFl" +
				"oat\",\r\n  \"Energistics.Etp.v12.Datatypes.ArrayOfDouble\",\r\n  \"Energistics.Etp.v12." +
				"Datatypes.ArrayOfString\",\r\n  \"Energistics.Etp.v12.Datatypes.AnySparseArray\"\r\n]}}" +
				",{\"name\":\"valueAttributes\",\"default\":[],\"type\":{\"type\":\"array\",\"items\":{\"type\":\"" +
				"record\",\"name\":\"DataAttribute\",\"namespace\":\"Energistics.Etp.v12.Datatypes\",\"fiel" +
				"ds\":[{\"name\":\"attributeId\",\"type\":\"int\"},{\"name\":\"attributeValue\",\"type\":\"DataVa" +
				"lue\"}],\"fullName\":\"Energistics.Etp.v12.Datatypes.DataAttribute\",\"depends\":[\r\n  \"" +
				"Energistics.Etp.v12.Datatypes.DataValue\"\r\n]}}}],\"fullName\":\"Energistics.Etp.v12." +
				"Datatypes.ChannelData.FramePoint\",\"depends\":[\r\n  \"Energistics.Etp.v12.Datatypes." +
				"DataValue\",\r\n  \"Energistics.Etp.v12.Datatypes.DataAttribute\"\r\n]}}}],\"fullName\":\"" +
				"Energistics.Etp.v12.Datatypes.ChannelData.FrameRow\",\"depends\":[\r\n  \"Energistics." +
				"Etp.v12.Datatypes.IndexValue\",\r\n  \"Energistics.Etp.v12.Datatypes.ChannelData.Fra" +
				"mePoint\"\r\n]}}}],\"protocol\":\"2\",\"messageType\":\"6\",\"senderRole\":\"store\",\"protocolR" +
				"oles\":\"store,customer\",\"multipartFlag\":true,\"fullName\":\"Energistics.Etp.v12.Prot" +
				"ocol.ChannelDataFrame.GetFrameResponseRows\",\"depends\":[\r\n  \"Energistics.Etp.v12." +
				"Datatypes.ChannelData.FrameRow\"\r\n]}");
		private IList<Energistics.Etp.v12.Datatypes.ChannelData.FrameRow> _frame;
		public virtual Schema Schema
		{
			get
			{
				return GetFrameResponseRows._SCHEMA;
			}
		}
		public IList<Energistics.Etp.v12.Datatypes.ChannelData.FrameRow> Frame
		{
			get
			{
				return this._frame;
			}
			set
			{
				this._frame = value;
			}
		}
		public virtual object Get(int fieldPos)
		{
			switch (fieldPos)
			{
			case 0: return this._frame;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Get()");
			};
		}
		public virtual void Put(int fieldPos, object fieldValue)
		{
			switch (fieldPos)
			{
			case 0: this._frame = (IList<Energistics.Etp.v12.Datatypes.ChannelData.FrameRow>)fieldValue; break;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Put()");
			};
		}
	}
}
