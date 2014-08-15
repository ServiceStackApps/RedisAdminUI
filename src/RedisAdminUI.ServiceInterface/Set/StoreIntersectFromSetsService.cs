using RedisAdminUI.ServiceModel.Operations.Set;

namespace RedisAdminUI.ServiceInterface.Set
{
	public class StoreIntersectFromSetsService : RedisServiceBase
	{
		public object Any(StoreIntersectFromSets request)
		{
			Redis.StoreIntersectFromSets(request.Id, request.SetIds.ToArray());

			return new StoreIntersectFromSetsResponse();
		}
	}
}