using RedisAdminUI.ServiceModel.Operations.Common;

namespace RedisAdminUI.ServiceInterface.Common
{
	public class SetEntryIfNotExistsService : RedisServiceBase
	{
		public object Any(SetEntryIfNotExists request)
		{
			return new SetEntryIfNotExistsResponse
       		{
				Result = Redis.SetEntryIfNotExists(request.Key, request.Value)
       		};
		}
	}
}