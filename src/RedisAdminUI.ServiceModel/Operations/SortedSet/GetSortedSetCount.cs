using System.Runtime.Serialization;
using ServiceStack;
using ServiceStack.Model;

namespace RedisAdminUI.ServiceModel.Operations.SortedSet
{
	[DataContract]
	public class GetSortedSetCount
		: IHasStringId
	{
		[DataMember]
		public string Id { get; set; }
	}

	[DataContract]
	public class GetSortedSetCountResponse
	{
		public GetSortedSetCountResponse()
		{
			this.ResponseStatus = new ResponseStatus();
		}

		[DataMember]
		public long Count { get; set; }

		[DataMember]
		public ResponseStatus ResponseStatus { get; set; }
	}
}