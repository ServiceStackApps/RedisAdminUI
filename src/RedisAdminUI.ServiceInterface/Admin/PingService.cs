using RedisAdminUI.ServiceModel.Operations.Common;

namespace RedisAdminUI.ServiceInterface.Admin
{
	public class PingService : RedisServiceBase
	{
		public object Any(Ping request)
		{
			return new PingResponse
	       	{
	       		Result = RedisNative.Ping()
	       	};
		}
	}
}