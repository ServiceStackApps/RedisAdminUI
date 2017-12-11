using RedisAdminUI.ServiceModel.Operations.Common;

namespace RedisAdminUI.ServiceInterface.Common
{
	public class SetEntryService : RedisServiceBase
	{
		public object Any(SetEntry request)
		{
			Redis.SetValue(request.Key, request.Value);
			
			return new SetEntryResponse();
		}
	}
}