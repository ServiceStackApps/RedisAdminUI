using RedisAdminUI.ServiceModel.Operations.Common;

namespace RedisAdminUI.ServiceInterface.Common
{
	public class AppendToValueService : RedisServiceBase
	{
		public object Any(AppendToValue request)
		{
			return new AppendToValueResponse
			{
				ValueLength = Redis.AppendToValue(request.Key, request.Value)
			};
		}
	}
}