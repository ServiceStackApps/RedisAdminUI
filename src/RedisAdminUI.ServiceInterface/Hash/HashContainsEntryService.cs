using RedisAdminUI.ServiceModel.Operations.Hash;

namespace RedisAdminUI.ServiceInterface.Hash
{
	public class HashContainsEntryService : RedisServiceBase
	{
		public object Any(HashContainsEntry request)
		{
			return new HashContainsEntryResponse
			{
				Result= Redis.HashContainsEntry(request.Id, request.Key)
			};
		}
	}
}