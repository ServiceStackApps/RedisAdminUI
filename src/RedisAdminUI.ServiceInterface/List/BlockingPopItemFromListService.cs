using RedisAdminUI.ServiceModel.Operations.List;

namespace RedisAdminUI.ServiceInterface.List
{
	public class BlockingPopItemFromListService : RedisServiceBase
	{
		public object Any(BlockingPopItemFromList request)
		{
			return new BlockingPopItemFromListResponse
			{
				Item = Redis.BlockingPopItemFromList(request.Id, request.TimeOut)
			};
		}
	}
}