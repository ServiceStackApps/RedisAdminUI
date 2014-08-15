using RedisAdminUI.ServiceModel.Operations.List;

namespace RedisAdminUI.ServiceInterface.List
{
	public class PopAndPushItemBetweenListsService : RedisServiceBase
	{
		public object Any(PopAndPushItemBetweenLists request)
		{
			return new PopAndPushItemBetweenListsResponse
			{
				Item = Redis.PopAndPushItemBetweenLists(request.FromListId, request.ToListId)
			};
		}
	}
}