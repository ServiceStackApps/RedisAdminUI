using RedisAdminUI.ServiceModel.Operations.SortedSet;
using RedisAdminUI.ServiceModel.Types;

namespace RedisAdminUI.ServiceInterface.SortedSet
{
	public class GetRangeWithScoresFromSortedSetByLowestScoreService : RedisServiceBase
	{
		public object Any(GetRangeWithScoresFromSortedSetByLowestScore request)
		{
			var itemsScoreMap = Redis.GetRangeWithScoresFromSortedSetByLowestScore(
				request.Id, request.FromScore, request.ToScore, request.Skip, request.Take);

			return new GetRangeWithScoresFromSortedSetByLowestScoreResponse
	       	{
				ItemsWithScores = new ArrayOfItemWithScore(itemsScoreMap.ToItemsWithScores())
	       	};
		}
	}
}