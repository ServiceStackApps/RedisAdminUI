using RedisAdminUI.ServiceModel.Operations.List;

namespace RedisAdminUI.ServiceInterface.List
{
	public class RemoveAllFromListService : RedisServiceBase
	{
		public object Any(RemoveAllFromList request)
		{
			Redis.RemoveAllFromList(request.Id);

			return new RemoveAllFromListResponse();
		}
	}
}