using RedisAdminUI.ServiceModel.Operations.List;

namespace RedisAdminUI.ServiceInterface.List
{
	public class PrependItemToListService : RedisServiceBase
	{
		public object Any(PrependItemToList request)
		{
			Redis.PrependItemToList(request.Id, request.Item);

			return new PrependItemToListResponse();
		}
	}
}