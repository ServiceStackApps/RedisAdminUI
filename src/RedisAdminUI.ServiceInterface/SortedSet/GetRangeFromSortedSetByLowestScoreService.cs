using RedisAdminUI.ServiceModel.Operations.SortedSet;
using ServiceStack;

namespace RedisAdminUI.ServiceInterface.SortedSet
{
	public class GetRangeFromSortedSetByLowestScoreService
		: RedisServiceBase
	{
		public object Any(GetRangeFromSortedSetByLowestScore request)
		{
			return new GetRangeFromSortedSetByLowestScoreResponse
	       	{
				Items = new ArrayOfString
				(
					Redis.GetRangeFromSortedSetByLowestScore(
						request.Id, request.FromScore, request.ToScore, request.Skip, request.Take)
				)
	       	};
		}
	}
}