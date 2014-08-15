using RedisAdminUI.ServiceModel.Operations.List;

namespace RedisAdminUI.ServiceInterface.List
{
	public class RemoveEndFromListService : RedisServiceBase
	{
		public object Any(RemoveEndFromList request)
		{
			return new RemoveEndFromListResponse
			{
				Item = Redis.RemoveEndFromList(request.Id)
			};
		}
	}
}