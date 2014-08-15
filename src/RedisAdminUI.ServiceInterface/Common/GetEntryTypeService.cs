using RedisAdminUI.ServiceModel.Operations.Common;

namespace RedisAdminUI.ServiceInterface.Common
{
	public class GetEntryTypeService : RedisServiceBase
	{
		public object Any(GetEntryType request)
		{
			return new GetEntryTypeResponse
			{
				KeyType = Redis.GetEntryType(request.Key).ToString()
			};
		}
	}
}