using RedisAdminUI.ServiceModel.Operations.SortedSet;

namespace RedisAdminUI.ServiceInterface.SortedSet
{
	public class IncrementItemInSortedSetService
		: RedisServiceBase
	{
		public object Any(IncrementItemInSortedSet request)
		{
			return new IncrementItemInSortedSetResponse
	       	{
				Score = Redis.IncrementItemInSortedSet(request.Id, request.Item, request.IncrementBy.GetValueOrDefault(1))
	       	};
		}
	}
}