using RedisAdminUI.ServiceModel.Operations.List;

namespace RedisAdminUI.ServiceInterface.List
{
	public class PushItemToListService : RedisServiceBase
	{
		public object Any(PushItemToList request)
		{
		    Redis.PushItemToList(request.Id, request.Item);

			return new PushItemToListResponse();
		}
	}
}