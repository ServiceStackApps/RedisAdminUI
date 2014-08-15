using RedisAdminUI.ServiceModel.Operations.Set;

namespace RedisAdminUI.ServiceInterface.Set
{
	public class GetSetCountService : RedisServiceBase
	{
		public object Any(GetSetCount request)
		{
			return new GetSetCountResponse
	       	{
				Count = Redis.GetSetCount(request.Id)
	       	};
		}
	}
}