using System.Collections.Generic;
using System.Runtime.Serialization;
using RedisAdminUI.ServiceModel.Types;
using ServiceStack.Model;
using ServiceStack;

namespace RedisAdminUI.ServiceModel.Operations.Hash
{
	[DataContract]
	public class GetValueFromHash
		: IHasStringId
	{
		[DataMember]
		public string Id { get; set; }

		[DataMember]
		public string Key { get; set; }
	}

	[DataContract]
	public class GetValueFromHashResponse
	{
		public GetValueFromHashResponse()
		{
			this.ResponseStatus = new ResponseStatus();
		}

		[DataMember]
		public string Value { get; set; }

		[DataMember]
		public ResponseStatus ResponseStatus { get; set; }
	}
}