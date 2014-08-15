using System;
using System.Runtime.Serialization;
using ServiceStack;

namespace RedisAdminUI.ServiceModel.Operations.Common
{
	[DataContract]
	public class SetEntryIfNotExists
	{
		[DataMember]
		public string Key { get; set; }

		[DataMember]
		public string Value { get; set; }
	}

	[DataContract]
	public class SetEntryIfNotExistsResponse
	{
		public SetEntryIfNotExistsResponse()
		{
			this.ResponseStatus = new ResponseStatus();
		}

		[DataMember]
		public bool Result { get; set; }

		[DataMember]
		public ResponseStatus ResponseStatus { get; set; }
	}
}