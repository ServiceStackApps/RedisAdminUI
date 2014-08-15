using RedisAdminUI.ServiceModel.Operations.List;

namespace RedisAdminUI.ServiceInterface.List
{
	public class SetItemInListService : RedisServiceBase
	{
		public object Any(SetItemInList request)
		{
			Redis.SetItemInList(request.Id, request.Index, request.Item);

			return new SetItemInListResponse();
		}
	}
}