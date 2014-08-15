using RedisAdminUI.ServiceModel.Operations.SortedSet;

namespace RedisAdminUI.ServiceInterface.SortedSet
{
	public class StoreIntersectFromSortedSetsService : RedisServiceBase
	{
		public object Any(StoreIntersectFromSortedSets request)
		{
			return new StoreIntersectFromSortedSetsResponse
	       	{
				Count = Redis.StoreIntersectFromSortedSets(request.Id, request.FromSetIds.ToArray())
	       	};
		}
	}
}