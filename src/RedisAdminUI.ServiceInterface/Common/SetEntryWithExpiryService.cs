using RedisAdminUI.ServiceModel.Operations.Common;

namespace RedisAdminUI.ServiceInterface.Common
{
	public class SetEntryWithExpiryService : RedisServiceBase
	{
		public object Any(SetEntryWithExpiry request)
		{
			Redis.SetEntry(request.Key, request.Value, request.ExpireIn);
			
			return new SetEntryWithExpiryResponse();
		}
	}
}