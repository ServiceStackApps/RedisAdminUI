using RedisAdminUI.ServiceModel.Operations.Set;

namespace RedisAdminUI.ServiceInterface.Set
{
	public class StoreUnionFromSetsService : RedisServiceBase
	{
		public object Any(StoreUnionFromSets request)
		{
			Redis.StoreUnionFromSets(request.Id, request.SetIds.ToArray());

			return new StoreUnionFromSetsResponse();
		}
	}
}