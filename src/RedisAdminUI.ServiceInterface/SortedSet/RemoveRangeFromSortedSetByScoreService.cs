using RedisAdminUI.ServiceModel.Operations.SortedSet;

namespace RedisAdminUI.ServiceInterface.SortedSet
{
	public class RemoveRangeFromSortedSetByScoreService : RedisServiceBase
	{
		public object Any(RemoveRangeFromSortedSetByScore request)
		{
			return new RemoveRangeFromSortedSetByScoreResponse
	       	{
				ItemsRemovedCount = Redis.RemoveRangeFromSortedSetByScore(
					request.Id, request.FromScore, request.ToScore)
	       	};
		}
	}
}