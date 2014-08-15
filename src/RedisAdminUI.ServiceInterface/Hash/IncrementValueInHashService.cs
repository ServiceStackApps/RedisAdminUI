using RedisAdminUI.ServiceModel.Operations.Hash;

namespace RedisAdminUI.ServiceInterface.Hash
{
	public class IncrementValueInHashService : RedisServiceBase
	{
		public object Any(IncrementValueInHash request)
		{
			return new IncrementValueInHashResponse
			{
				Value = Redis.IncrementValueInHash(
					request.Id, request.Key, request.IncrementBy.GetValueOrDefault(1))
			};
		}
	}
}