using System.Collections.Generic;
using System.Runtime.Serialization;
using ServiceStack;
using ServiceStack.Model;

namespace RedisAdminUI.ServiceModel.Operations.SortedSet
{
	[DataContract]
	public class StoreIntersectFromSortedSets
		: IHasStringId
	{
		public StoreIntersectFromSortedSets()
		{
			this.FromSetIds = new List<string>();
		}

		[DataMember]
		public string Id { get; set; }

		[DataMember]
		public List<string> FromSetIds { get; set; }
	}

	[DataContract]
	public class StoreIntersectFromSortedSetsResponse
	{
		public StoreIntersectFromSortedSetsResponse()
		{
			this.ResponseStatus = new ResponseStatus();
		}

		[DataMember]
		public long Count { get; set; }

		[DataMember]
		public ResponseStatus ResponseStatus { get; set; }
	}
}