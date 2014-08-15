using RedisAdminUI.ServiceModel.Operations.List;

namespace RedisAdminUI.ServiceInterface.List
{
	public class BlockingRemoveStartFromListService : RedisServiceBase
	{
		public object Any(BlockingRemoveStartFromList request)
		{
			return new BlockingRemoveStartFromListResponse
			{
				Item = Redis.BlockingRemoveStartFromList(request.Id, request.TimeOut)
			};
		}
	}
}