using RedisAdminUI.ServiceModel.Operations.Set;

namespace RedisAdminUI.ServiceInterface.Set
{
	public class PopItemFromSetService : RedisServiceBase
	{
		public object Any(PopItemFromSet request)
		{
			return new PopItemFromSetResponse
	       	{
				Item = Redis.PopItemFromSet(request.Id)
	       	};
		}
	}
}