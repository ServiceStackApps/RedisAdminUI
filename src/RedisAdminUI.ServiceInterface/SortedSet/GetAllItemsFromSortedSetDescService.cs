using RedisAdminUI.ServiceModel.Operations.SortedSet;
using ServiceStack;

namespace RedisAdminUI.ServiceInterface.SortedSet
{
	public class GetAllItemsFromSortedSetDescService : RedisServiceBase
	{
		public object Any(GetAllItemsFromSortedSetDesc request)
		{
			return new GetAllItemsFromSortedSetDescResponse
	       	{
	       		Items = new ArrayOfString(Redis.GetAllItemsFromSortedSetDesc(request.Id))
	       	};
		}
	}
}