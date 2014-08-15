using RedisAdminUI.ServiceModel.Operations.SortedSet;

namespace RedisAdminUI.ServiceInterface.SortedSet
{
	public class GetItemIndexInSortedSetService
		: RedisServiceBase
	{
		public object Any(GetItemIndexInSortedSet request)
		{
			return new GetItemIndexInSortedSetResponse
	       	{
				Index = Redis.GetItemIndexInSortedSet(request.Id, request.Item)
	       	};
		}
	}
}