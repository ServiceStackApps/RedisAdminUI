using RedisAdminUI.ServiceModel.Operations.Hash;

namespace RedisAdminUI.ServiceInterface.Hash
{
	public class RemoveEntryFromHashService
		: RedisServiceBase
	{
		public object Any(RemoveEntryFromHash request)
		{
			return new RemoveEntryFromHashResponse
			{
				Result = Redis.RemoveEntryFromHash(request.Id, request.Key)
			};
		}
	}
}