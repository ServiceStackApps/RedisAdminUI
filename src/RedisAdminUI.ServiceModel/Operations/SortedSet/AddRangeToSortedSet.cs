using System.Collections.Generic;
using System.Runtime.Serialization;
using RedisAdminUI.ServiceModel.Types;
using ServiceStack.Model;
using ServiceStack;

namespace RedisAdminUI.ServiceModel.Operations.SortedSet
{
	[DataContract]
	public class AddRangeToSortedSet
		: IHasStringId
	{
		public AddRangeToSortedSet()
		{
			this.Items = new List<ItemWithScore>();
		}

		[DataMember] 
		public string Id { get; set; }

		[DataMember]
		public List<ItemWithScore> Items { get; set; }
	}

	[DataContract]
	public class AddRangeToSortedSetResponse
	{
		public AddRangeToSortedSetResponse()
		{
			this.ResponseStatus = new ResponseStatus();
		}

		[DataMember]
		public ResponseStatus ResponseStatus { get; set; }
	}
}