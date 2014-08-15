using RedisAdminUI.ServiceModel.Operations.Hash;

namespace RedisAdminUI.ServiceInterface.Hash
{
	public class SetEntryInHashIfNotExistsService : RedisServiceBase
	{
		public object Any(SetEntryInHashIfNotExists request)
		{
			return new SetEntryInHashIfNotExistsResponse
			{
				Result = Redis.SetEntryInHashIfNotExists(request.Id, request.Key, request.Value)
			};
		}
	}
}