using RedisAdminUI.ServiceModel.Operations.Set;

namespace RedisAdminUI.ServiceInterface.Set
{
	public class AddItemToSetService : RedisServiceBase
	{
		public object Any(AddItemToSet request)
		{
			Redis.AddItemToSet(request.Id, request.Item);

			return new AddItemToSetResponse();
		}
	}
}