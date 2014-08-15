using RedisAdminUI.ServiceModel.Operations.Admin;

namespace RedisAdminUI.ServiceInterface.Admin
{
	public class ShutdownService : RedisServiceBase
	{
		public object Any(Shutdown request)
		{
            Redis.Shutdown();
			
			return new ShutdownResponse();
		}
	}
}