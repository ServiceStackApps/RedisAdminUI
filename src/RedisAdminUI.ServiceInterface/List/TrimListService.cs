using RedisAdminUI.ServiceModel.Operations.List;

namespace RedisAdminUI.ServiceInterface.List
{
	public class TrimListService : RedisServiceBase
	{
		public object Any(TrimList request)
		{
			Redis.TrimList(request.Id, request.KeepStartingFrom, request.KeepEndingAt);

			return new TrimListResponse();
		}
	}
}