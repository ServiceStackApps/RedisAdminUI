using RedisAdminUI.ServiceModel.Operations.Hash;
using ServiceStack;

namespace RedisAdminUI.ServiceInterface.Hash
{
	public class GetHashKeysService : RedisServiceBase
	{
		public object Any(GetHashKeys request)
		{
			return new GetHashKeysResponse
			{
				Keys = new ArrayOfString(Redis.GetHashKeys(request.Id))
			};
		}
	}
}