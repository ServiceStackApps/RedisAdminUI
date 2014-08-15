using RedisAdminUI.ServiceModel.Operations.SortedSet;

namespace RedisAdminUI.ServiceInterface.SortedSet
{
	public class SortedSetContainsItemService : RedisServiceBase
	{
		public object Any(SortedSetContainsItem request)
		{
			return new SortedSetContainsItemResponse
	       	{
				Result = Redis.SortedSetContainsItem(request.Id, request.Item)
	       	};
		}
	}
}