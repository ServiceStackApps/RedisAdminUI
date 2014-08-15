using RedisAdminUI.ServiceModel.Operations.SortedSet;

namespace RedisAdminUI.ServiceInterface.SortedSet
{
	public class StoreUnionFromSortedSetsService : RedisServiceBase
	{
		public object Any(StoreUnionFromSortedSets request)
		{
			return new StoreUnionFromSortedSetsResponse
	       	{
				Count = Redis.StoreUnionFromSortedSets(request.Id, request.FromSetIds.ToArray())
	       	};
		}
	}
}