using RedisAdminUI.ServiceModel.Operations.Common;

namespace RedisAdminUI.ServiceInterface.Common
{
	public class GetAndSetEntryService : RedisServiceBase
	{
		public object Any(GetAndSetEntry request)
		{
			return new GetAndSetEntryResponse
			{
				ExistingValue = Redis.GetAndSetEntry(request.Key, request.Value)
			};
		}
	}
}