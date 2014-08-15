using RedisAdminUI.ServiceModel.Operations.Hash;

namespace RedisAdminUI.ServiceInterface.Hash
{
	public class SetEntryInHashService : RedisServiceBase
	{
		public object Any(SetEntryInHash request)
		{
			return new SetEntryInHashResponse
			{
				Result = Redis.SetEntryInHash(request.Id, request.Key, request.Value)
			};
		}
	}
}