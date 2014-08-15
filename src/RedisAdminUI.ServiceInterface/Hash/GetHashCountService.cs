using RedisAdminUI.ServiceModel.Operations.Hash;

namespace RedisAdminUI.ServiceInterface.Hash
{
	public class GetHashCountService : RedisServiceBase
	{
		public object Any(GetHashCount request)
		{
			return new GetHashCountResponse
			{
				Count = Redis.GetHashCount(request.Id)
			};
		}
	}
}