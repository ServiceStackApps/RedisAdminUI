using RedisAdminUI.ServiceModel.Operations.SortedSet;

namespace RedisAdminUI.ServiceInterface.SortedSet
{
	public class AddItemToSortedSetService : RedisServiceBase
	{
		public object Any(AddItemToSortedSet request)
		{
			Redis.AddItemToSortedSet(request.Id, request.Item);

			return new AddItemToSortedSetResponse();
		}
	}
}