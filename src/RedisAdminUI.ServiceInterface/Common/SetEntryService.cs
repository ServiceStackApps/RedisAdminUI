using RedisAdminUI.ServiceModel.Operations.Common;

namespace RedisAdminUI.ServiceInterface.Common
{
	public class SetEntryService : RedisServiceBase
	{
		public object Any(SetEntry request)
		{
			Redis.SetEntry(request.Key, request.Value);
			
			return new SetEntryResponse();
		}
	}
}