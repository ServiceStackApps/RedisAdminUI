using RedisAdminUI.ServiceModel.Operations.List;

namespace RedisAdminUI.ServiceInterface.List
{
	public class DequeueItemFromListService : RedisServiceBase
	{
		public object Any(DequeueItemFromList request)
		{
			return new DequeueItemFromListResponse
			{
				Item = Redis.DequeueItemFromList(request.Id)
			};
		}
	}
}