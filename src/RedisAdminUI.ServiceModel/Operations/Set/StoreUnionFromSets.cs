using System.Collections.Generic;
using System.Runtime.Serialization;
using ServiceStack.Model;
using ServiceStack;

namespace RedisAdminUI.ServiceModel.Operations.Set
{
	[DataContract]
	public class StoreUnionFromSets
		: IHasStringId
	{
		public StoreUnionFromSets()
		{
			this.SetIds = new List<string>();
		}

		[DataMember]
		public string Id { get; set; }

		[DataMember]
		public List<string> SetIds { get; set; }
	}

	[DataContract]
	public class StoreUnionFromSetsResponse
	{
		public StoreUnionFromSetsResponse()
		{
			this.ResponseStatus = new ResponseStatus();
		}

		[DataMember]
		public ResponseStatus ResponseStatus { get; set; }
	}
}