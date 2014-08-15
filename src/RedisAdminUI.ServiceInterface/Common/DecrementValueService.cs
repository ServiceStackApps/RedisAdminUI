using RedisAdminUI.ServiceModel.Operations.Common;

namespace RedisAdminUI.ServiceInterface.Common
{
	public class DecrementValueService : RedisServiceBase
	{
		public object Any(DecrementValue request)
		{
			return new DecrementValueResponse
			{
				Value = Redis.DecrementValueBy(
					request.Key, request.DecrementBy.GetValueOrDefault(1))
			};
		}
	}
}