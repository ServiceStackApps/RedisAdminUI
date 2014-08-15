using System.Runtime.Serialization;
using RedisAdminUI.ServiceModel.Types;
using ServiceStack.Model;
using ServiceStack;

namespace RedisAdminUI.ServiceModel.Operations.SortedSet
{
	[DataContract]
	public class GetRangeWithScoresFromSortedSetByHighestScore
		: IHasStringId
	{
		[DataMember]
		public string Id { get; set; }

		[DataMember]
		public double FromScore { get; set; }

		[DataMember]
		public double ToScore { get; set; }

		[DataMember]
		public int? Skip { get; set; }

		[DataMember]
		public int? Take { get; set; }
	}

	[DataContract]
	public class GetRangeWithScoresFromSortedSetByHighestScoreResponse
	{
		public GetRangeWithScoresFromSortedSetByHighestScoreResponse()
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