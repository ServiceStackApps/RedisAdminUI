using RedisAdminUI.ServiceModel.Operations.List;

namespace RedisAdminUI.ServiceInterface.List
{
	public class RemoveItemFromListService : RedisServiceBase
	{
		public object Any(RemoveItemFromList request)
		{
			return new RemoveItemFromListResponse
			{
				ItemsRemovedCount = Redis.RemoveItemFromList(request.Id, 
					request.Item, 0)
			};
		}
	}
}