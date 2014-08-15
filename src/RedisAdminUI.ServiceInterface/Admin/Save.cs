using RedisAdminUI.ServiceModel.Operations.Admin;

namespace RedisAdminUI.ServiceInterface.Admin
{
	public class SaveService : RedisServiceBase
	{
		public object Any(Save request)
		{
			if (request.InBackground)
			{
				Redis.SaveAsync();
			}
			else
			{
                Redis.Save();
            }
			
			return new SaveResponse();
		}
	}
}