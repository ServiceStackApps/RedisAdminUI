using RedisAdminUI.ServiceModel.Operations.SortedSet;
using RedisAdminUI.ServiceModel.Types;

namespace RedisAdminUI.ServiceInterface.SortedSet
{
	public class GetRangeWithScoresFromSortedSetService : RedisServiceBase
	{
		public object Any(GetRangeWithScoresFromSortedSet request)
		{
			var itemsScoreMap = Redis.GetRangeWithScoresFromSortedSet(request.Id, request.FromRank, request.ToRank);

			return new GetRangeWithScoresFromSortedSetResponse
	       	{
				ItemsWithScores = new ArrayOfItemWithScore(itemsScoreMap.ToItemsWithScores())
	       	};
		}
	}
}