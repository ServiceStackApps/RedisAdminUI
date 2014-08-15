using RedisAdminUI.ServiceModel.Operations.Set;
using ServiceStack;

namespace RedisAdminUI.ServiceInterface.Set
{
	public class GetAllItemsFromSetService : RedisServiceBase
	{
		public object Any(GetAllItemsFromSet request)
		{
			return new GetAllItemsFromSetResponse
	       	{
	       		Items = new ArrayOfString(Redis.GetAllItemsFromSet(request.Id))
	       	};
		}
	}
}