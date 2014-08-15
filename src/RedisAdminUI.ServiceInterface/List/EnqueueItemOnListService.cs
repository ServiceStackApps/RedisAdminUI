using RedisAdminUI.ServiceModel.Operations.List;

namespace RedisAdminUI.ServiceInterface.List
{
	public class EnqueueItemOnListService : RedisServiceBase
	{
		public object Any(EnqueueItemOnList request)
		{
			Redis.EnqueueItemOnList(request.Id, request.Item);

			return new EnqueueItemOnListResponse();
		}
	}
}