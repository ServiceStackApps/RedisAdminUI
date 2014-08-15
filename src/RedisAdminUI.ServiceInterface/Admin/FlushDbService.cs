using RedisAdminUI.ServiceModel.Operations.Admin;
using ServiceStack;

namespace RedisAdminUI.ServiceInterface.Admin
{
	public class FlushDbService : Service
	{
		public object Any(FlushDb request)
		{
			if (request.Db == 0)
			{
                Redis.FlushDb();
			}
			else
			{

			    Redis.Db = request.Db;
                Redis.FlushDb();
			}
			
			return new FlushDbResponse();
		}
	}
}