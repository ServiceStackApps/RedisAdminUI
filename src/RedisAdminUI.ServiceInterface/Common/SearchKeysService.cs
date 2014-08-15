using RedisAdminUI.ServiceModel.Operations.Common;
using ServiceStack;

namespace RedisAdminUI.ServiceInterface.Common
{
	public class SearchKeysService : RedisServiceBase
	{
		public object Any(SearchKeys request)
		{
			return new SearchKeysResponse
			{
				Keys = new ArrayOfString(Redis.SearchKeys(request.Pattern))
			};
		}
	}
}