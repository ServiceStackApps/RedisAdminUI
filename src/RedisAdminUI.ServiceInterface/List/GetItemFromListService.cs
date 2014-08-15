using RedisAdminUI.ServiceModel.Operations.List;

namespace RedisAdminUI.ServiceInterface.List
{
	public class GetItemFromListService : RedisServiceBase
	{
		public object Any(GetItemFromList request)
		{
			return new GetItemFromListResponse
			{
				Item = Redis.GetItemFromList(request.Id, request.Index)
			};
		}
	}
}