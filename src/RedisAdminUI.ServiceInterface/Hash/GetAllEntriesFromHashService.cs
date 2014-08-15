using RedisAdminUI.ServiceModel.Operations.Hash;
using RedisAdminUI.ServiceModel.Types;

namespace RedisAdminUI.ServiceInterface.Hash
{
	public class GetAllEntriesFromHashService : RedisServiceBase
	{
		public object Any(GetAllEntriesFromHash request)
		{
			return new GetAllEntriesFromHashResponse
			{
				KeyValuePairs = new ArrayOfKeyValuePair(
					Redis.GetAllEntriesFromHash(request.Id)
				)
			};
		}
	}
}