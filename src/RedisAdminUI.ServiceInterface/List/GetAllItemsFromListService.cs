using RedisAdminUI.ServiceModel.Operations.List;
using ServiceStack;

namespace RedisAdminUI.ServiceInterface.List
{
	public class GetAllItemsFromListService : RedisServiceBase
	{
		public object Any(GetAllItemsFromList request)
		{
			return new GetAllItemsFromListResponse
			{
				Items = new ArrayOfString(Redis.GetAllItemsFromList(request.Id))
			};
		}
	}
}