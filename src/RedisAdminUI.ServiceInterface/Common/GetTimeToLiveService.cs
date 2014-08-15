using RedisAdminUI.ServiceModel.Operations.Common;

namespace RedisAdminUI.ServiceInterface.Common
{
	public class GetTimeToLiveService : RedisServiceBase
	{
		public object Any(GetTimeToLive request)
		{
			return new GetTimeToLiveResponse
			{
				TimeRemaining = Redis.GetTimeToLive(request.Key)
			};
		}
	}
}