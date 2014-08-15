using RedisAdminUI.ServiceModel.Operations.Common;

namespace RedisAdminUI.ServiceInterface.Common
{
	public class IncrementValueService : RedisServiceBase
	{
		public object Any(IncrementValue request)
		{
			return new IncrementValueResponse
			{
				Value = Redis.IncrementValueBy(request.Key, request.IncrementBy.GetValueOrDefault(1))
			};
		}
	}
}