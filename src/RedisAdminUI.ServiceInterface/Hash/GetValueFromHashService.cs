using RedisAdminUI.ServiceModel.Operations.Hash;

namespace RedisAdminUI.ServiceInterface.Hash
{
	public class GetValueFromHashService : RedisServiceBase
	{
		public object Any(GetValueFromHash request)
		{
			return new GetValueFromHashResponse
			{
				Value = Redis.GetValueFromHash(request.Id, request.Key)
			};
		}
	}
}