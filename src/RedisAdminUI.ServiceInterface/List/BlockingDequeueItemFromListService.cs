using RedisAdminUI.ServiceModel.Operations.List;

namespace RedisAdminUI.ServiceInterface.List
{
	public class BlockingDequeueItemFromListService : RedisServiceBase
	{
		public object Any(BlockingDequeueItemFromList request)
		{
			return new BlockingDequeueItemFromListResponse
	       	{
				Item = Redis.BlockingDequeueItemFromList(request.Id, request.TimeOut)
	       	};
		}
	}
}