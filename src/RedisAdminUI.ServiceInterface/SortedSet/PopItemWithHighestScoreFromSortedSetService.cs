using RedisAdminUI.ServiceModel.Operations.SortedSet;

namespace RedisAdminUI.ServiceInterface.SortedSet
{
	public class PopItemWithHighestScoreFromSortedSetService : RedisServiceBase
	{
		public object Any(PopItemWithHighestScoreFromSortedSet request)
		{
			return new PopItemWithHighestScoreFromSortedSetResponse
	       	{
				Item = Redis.PopItemWithHighestScoreFromSortedSet(request.Id)
	       	};
		}
	}
}