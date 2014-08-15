using RedisAdminUI.ServiceModel.Operations.SortedSet;
using ServiceStack;

namespace RedisAdminUI.ServiceInterface.SortedSet
{
	public class GetAllItemsFromSortedSetService
		: RedisServiceBase
	{
		public object Any(GetAllItemsFromSortedSet request)
		{
			return new GetAllItemsFromSortedSetResponse
	       	{
	       		Items = new ArrayOfString(Redis.GetAllItemsFromSortedSet(request.Id))
	       	};
		}
	}
}