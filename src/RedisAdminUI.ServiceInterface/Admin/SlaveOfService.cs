using RedisAdminUI.ServiceModel.Operations.Admin;

namespace RedisAdminUI.ServiceInterface.Admin
{
	public class SlaveOfService : RedisServiceBase
	{
		public object Any(SlaveOf request)
		{
			if (request.NoOne)
			{
                RedisNative.SlaveOfNoOne();
			}
			else
			{
				RedisNative.SlaveOf(request.Host, request.Port);
			}
			
			return new SlaveOfResponse();
		}
	}
}