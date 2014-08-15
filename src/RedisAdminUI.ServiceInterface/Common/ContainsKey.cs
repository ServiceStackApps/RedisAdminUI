using RedisAdminUI.ServiceModel.Operations.Common;

namespace RedisAdminUI.ServiceInterface.Common
{
	public class ContainsKeyService : RedisServiceBase
	{
		public object Any(ContainsKey request)
		{
			return new ContainsKeyResponse
			{
				Result = Redis.ContainsKey(request.Key)
			};
		}
	}
}