using RedisAdminUI.ServiceModel.Operations.Hash;
using ServiceStack;

namespace RedisAdminUI.ServiceInterface.Hash
{
	public class GetHashValuesService : RedisServiceBase
	{
		public object Any(GetHashValues request)
		{
			return new GetHashValuesResponse
			{
				Values = new ArrayOfString(Redis.GetHashValues(request.Id))
			};
		}
	}
}