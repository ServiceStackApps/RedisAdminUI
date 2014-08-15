using RedisAdminUI.ServiceModel.Operations.List;

namespace RedisAdminUI.ServiceInterface.List
{
	public class PopItemFromListService : RedisServiceBase
	{
		public object Any(PopItemFromList request)
		{
			return new PopItemFromListResponse
			{
				Item = Redis.PopItemFromList(request.Id)
			};
		}
	}
}