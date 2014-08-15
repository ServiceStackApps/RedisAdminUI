using RedisAdminUI.ServiceModel.Operations.Set;

namespace RedisAdminUI.ServiceInterface.Set
{
	public class GetRandomItemFromSetService : RedisServiceBase
	{
		public object Any(GetRandomItemFromSet request)
		{
			return new GetRandomItemFromSetResponse
	       	{
				Item = Redis.GetRandomItemFromSet(request.Id)
	       	};
		}
	}
}