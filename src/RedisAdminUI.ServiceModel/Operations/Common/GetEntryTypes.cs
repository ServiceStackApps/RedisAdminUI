using System.Runtime.Serialization;
using System.Collections.Generic;
using RedisAdminUI.ServiceModel.Types;
using ServiceStack;

namespace RedisAdminUI.ServiceModel.Operations.Common
{
	[DataContract]
	public class GetEntryTypes
	{
		public GetEntryTypes()
		{
			this.Keys = new List<string>();
		}

		[DataMember] 
		public List<string> Keys { get; set; }
	}

	[DataContract]
	public class GetEntryTypesResponse
	{
		public GetEntryTypesResponse()
		{
			this.ResponseStatus = new ResponseStatus();

			this.KeyTypes = new ArrayOfKeyValuePair();
		}

		[DataMember] 
		public ArrayOfKeyValuePair KeyTypes { get; set; }

		[DataMember]
		public ResponseStatus ResponseStatus { get; set; }
	}
}