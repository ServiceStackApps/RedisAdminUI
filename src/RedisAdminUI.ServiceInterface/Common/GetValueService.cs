using RedisAdminUI.ServiceModel.Operations.Common;

namespace RedisAdminUI.ServiceInterface.Common
{
	public class GetValueService : RedisServiceBase
	{
		public object Any(GetValue request)
		{
			return new GetValueResponse
			{
				Value = Redis.GetValue(request.Key)
			};
		}
	}
}