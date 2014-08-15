using RedisAdminUI.ServiceModel.Operations.Common;
using ServiceStack;

namespace RedisAdminUI.ServiceInterface.Common
{
	public class GetAllKeysService : RedisServiceBase
	{
		public object Any(GetAllKeys request)
		{
			return new GetAllKeysResponse
			{
				Keys = new ArrayOfString(Redis.GetAllKeys())
			};
		}
	}
}