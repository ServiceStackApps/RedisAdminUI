using RedisAdminUI.ServiceModel.Operations.Common;

namespace RedisAdminUI.ServiceInterface.Common
{
	public class RemoveEntryService : RedisServiceBase
	{
		public object Any(RemoveEntry request)
		{
			return new RemoveEntryResponse
			{
				Result = Redis.RemoveEntry(request.Keys.ToArray())
			};
		}
	}
}