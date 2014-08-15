using RedisAdminUI.ServiceModel.Operations.SortedSet;

namespace RedisAdminUI.ServiceInterface.SortedSet
{
	public class PopItemWithLowestScoreFromSortedSetService : RedisServiceBase
	{
		public object Any(PopItemWithLowestScoreFromSortedSet request)
		{
			return new PopItemWithLowestScoreFromSortedSetResponse
	       	{
				Item = Redis.PopItemWithLowestScoreFromSortedSet(request.Id)
	       	};
		}
	}
}