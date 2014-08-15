using System.Collections.Generic;
using System.Runtime.Serialization;
using RedisAdminUI.ServiceModel.Types;
using ServiceStack.Model;
using ServiceStack;

namespace RedisAdminUI.ServiceModel.Operations.Hash
{
	[DataContract]
	public class SetRangeInHash
		: IHasStringId
	{
		public SetRangeInHash()
		{
			this.KeyValuePairs = new List<KeyValuePair>();
		}

		[DataMember]
		public string Id { get; set; }

		[DataMember]
		public List<KeyValuePair> KeyValuePairs { get; set; }
	}

	[DataContract]
	public class SetRangeInHashResponse
	{
		public SetRangeInHashResponse()
		{
			this.ResponseStatus = new ResponseStatus();
		}

		[DataMember]
		public ResponseStatus ResponseStatus { get; set; }
	}
}