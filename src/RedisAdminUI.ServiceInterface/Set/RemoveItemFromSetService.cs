using RedisAdminUI.ServiceModel.Operations.Set;

namespace RedisAdminUI.ServiceInterface.Set
{
	public class RemoveItemFromSetService : RedisServiceBase
	{
		public object Any(RemoveItemFromSet request)
		{
			Redis.RemoveItemFromSet(request.Id, request.Item);

			return new RemoveItemFromSetResponse();
		}
	}
}