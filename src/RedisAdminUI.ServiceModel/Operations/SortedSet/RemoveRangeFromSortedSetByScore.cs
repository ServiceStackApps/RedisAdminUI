using System.Runtime.Serialization;
using ServiceStack;
using ServiceStack.Model;

namespace RedisAdminUI.ServiceModel.Operations.SortedSet
{
	[DataContract]
	public class RemoveRangeFromSortedSetByScore
		: IHasStringId
	{
		[DataMember]
		public string Id { get; set; }

		[DataMember]
		public double FromScore { get; set; }

		[DataMember]
		public double ToScore { get; set; }
	}

	[DataContract]
	public class RemoveRangeFromSortedSetByScoreResponse
	{
		public RemoveRangeFromSortedSetByScoreResponse()
		{
			this.ResponseStatus = new ResponseStatus();
		}

		[DataMember]
		public long ItemsRemovedCount { get; set; }

		[DataMember]
		public ResponseStatus ResponseStatus { get; set; }
	}
}