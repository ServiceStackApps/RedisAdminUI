using RedisAdminUI.ServiceModel.Operations.Hash;
using ServiceStack;

namespace RedisAdminUI.ServiceInterface.Hash
{
	public class GetValuesFromHashService : RedisServiceBase
	{
		public object Any(GetValuesFromHash request)
		{
			return new GetValuesFromHashResponse
			{
				Values = new ArrayOfString(
					Redis.GetValuesFromHash(request.Id, request.Keys.ToArray())
				)
			};
		}
	}
}