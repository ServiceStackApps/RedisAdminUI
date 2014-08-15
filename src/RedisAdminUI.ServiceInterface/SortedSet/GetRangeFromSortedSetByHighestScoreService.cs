using RedisAdminUI.ServiceModel.Operations.SortedSet;
using ServiceStack;

namespace RedisAdminUI.ServiceInterface.SortedSet
{
	public class GetRangeFromSortedSetByHighestScoreService
		: RedisServiceBase
	{
		public object Any(GetRangeFromSortedSetByHighestScore request)
		{
			return new GetRangeFromSortedSetByHighestScoreResponse
	       	{
				Items = new ArrayOfString
				(
					Redis.GetRangeFromSortedSetByHighestScore(
						request.Id, request.FromScore, request.ToScore, request.Skip, request.Take)
				)
	       	};
		}
	}
}