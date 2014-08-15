using RedisAdminUI.ServiceModel.Operations.Common;

namespace RedisAdminUI.ServiceInterface.Common
{
	public class GetRandomKeyService : RedisServiceBase
	{
		public object Any(GetRandomKey request)
		{
			return new GetRandomKeyResponse
			{
				Key = Redis.GetRandomKey()
			};
		}
	}
}