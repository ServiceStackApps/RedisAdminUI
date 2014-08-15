using RedisAdminUI.ServiceModel.Operations.SortedSet;

namespace RedisAdminUI.ServiceInterface.SortedSet
{
	public class GetItemScoreInSortedSetService : RedisServiceBase
	{
		public object Any(GetItemScoreInSortedSet request)
		{
			return new GetItemScoreInSortedSetResponse
	       	{
				Score = Redis.GetItemScoreInSortedSet(request.Id, request.Item)
	       	};
		}
	}
}