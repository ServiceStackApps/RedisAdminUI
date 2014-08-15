using RedisAdminUI.ServiceModel.Operations.Common;
using RedisAdminUI.ServiceModel.Types;

namespace RedisAdminUI.ServiceInterface.Admin
{
	public class GetServerInfoService : RedisServiceBase
	{
		public object Any(GetServerInfo request)
		{
			return new GetServerInfoResponse
	       	{
				ServerInfo = new ArrayOfKeyValuePair(Redis.Info)
	       	};
		}
	}
}