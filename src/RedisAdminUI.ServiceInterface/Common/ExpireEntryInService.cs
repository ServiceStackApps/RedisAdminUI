using RedisAdminUI.ServiceModel.Operations.Common;

namespace RedisAdminUI.ServiceInterface.Common
{
	public class ExpireEntryInService : RedisServiceBase
	{
		public object Any(ExpireEntryIn request)
		{
			return new ExpireEntryInResponse
			{
				Result = Redis.ExpireEntryIn(request.Key, request.ExpireIn)
			};
		}
	}
}