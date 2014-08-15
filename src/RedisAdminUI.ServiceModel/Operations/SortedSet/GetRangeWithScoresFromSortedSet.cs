using System.Runtime.Serialization;
using RedisAdminUI.ServiceModel.Types;
using ServiceStack.Model;
using ServiceStack;

namespace RedisAdminUI.ServiceModel.Operations.SortedSet
{
	[DataContract]
	public class GetRangeWithScoresFromSortedSet
		: IHasStringId
	{
		[DataMember]
		public string Id { get; set; }

		[DataMember]
		public int FromRank { get; set; }

		[DataMember]
		public int ToRank { get; set; }
	}

	[DataContract]
	public class GetRangeWithScoresFromSortedSetResponse
	{
		public GetRangeWithScoresFromSortedSetResponse()
		{
			this.ResponseStatus = new ResponseStatus();

			this.ItemsWithScores = new ArrayOfItemWithScore();
		}

		[DataMember]
		public ArrayOfItemWithScore ItemsWithScores { get; set; }

		[DataMember]
		public ResponseStatus ResponseStatus { get; set; }
	}
}