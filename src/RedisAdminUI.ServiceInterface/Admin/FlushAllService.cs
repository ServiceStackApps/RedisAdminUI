using RedisAdminUI.ServiceModel.Operations.Admin;

namespace RedisAdminUI.ServiceInterface.Admin
{
	public class FlushAllService : RedisServiceBase
	{
	    public object Any(FlushAll request)
		{
            Redis.FlushAll();
			
			return new FlushAllResponse();
		}
	}
}