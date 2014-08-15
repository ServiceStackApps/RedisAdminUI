using RedisAdminUI.ServiceModel.Operations.SortedSet;

namespace RedisAdminUI.ServiceInterface.SortedSet
{
	public class RemoveItemFromSortedSetService : RedisServiceBase
	{
		public object Any(RemoveItemFromSortedSet request)
		{
			return new RemoveItemFromSortedSetResponse
	       	{
				Result = Redis.RemoveItemFromSortedSet(request.Id, request.Item)
	       	};
		}
	}
}