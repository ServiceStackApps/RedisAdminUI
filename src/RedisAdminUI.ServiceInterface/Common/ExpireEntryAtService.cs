using RedisAdminUI.ServiceModel.Operations.Common;

namespace RedisAdminUI.ServiceInterface.Common
{
	public class ExpireEntryAtService : RedisServiceBase
	{
		public object Any(ExpireEntryAt request)
		{
			return new ExpireEntryAtResponse
			{
				Result = Redis.ExpireEntryAt(request.Key, request.ExpireAt)
			};
		}
	}
}