using RedisAdminUI.ServiceModel.Operations.SortedSet;
using RedisAdminUI.ServiceModel.Types;

namespace RedisAdminUI.ServiceInterface.SortedSet
{
	public class GetRangeWithScoresFromSortedSetByHighestScoreService : RedisServiceBase
	{
		public object Any(GetRangeWithScoresFromSortedSetByHighestScore request)
		{
			var itemsScoreMap = Redis.GetRangeWithScoresFromSortedSetByHighestScore(
   				request.Id, request.FromScore, request.ToScore, request.Skip, request.Take);

			return new GetRangeWithScoresFromSortedSetByHighestScoreResponse
	       	{
				ItemsWithScores = new ArrayOfItemWithScore(itemsScoreMap.ToItemsWithScores())
	       	};
		}
	}
}