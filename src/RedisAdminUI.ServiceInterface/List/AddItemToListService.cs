using RedisAdminUI.ServiceModel.Operations.List;

namespace RedisAdminUI.ServiceInterface.List
{
	public class AddItemToListService : RedisServiceBase
	{
		public object Any(AddItemToList request)
		{
			Redis.AddItemToList(request.Id, request.Item);

			return new AddItemToListResponse();
		}
	}
}