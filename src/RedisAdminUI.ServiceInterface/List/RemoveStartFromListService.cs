using RedisAdminUI.ServiceModel.Operations.List;

namespace RedisAdminUI.ServiceInterface.List
{
	public class RemoveStartFromListService : RedisServiceBase
	{
		public object Any(RemoveStartFromList request)
		{
			return new RemoveStartFromListResponse
			{
				Item = Redis.RemoveStartFromList(request.Id)
			};
		}
	}
}