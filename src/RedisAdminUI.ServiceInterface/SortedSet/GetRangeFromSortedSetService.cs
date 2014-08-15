using RedisAdminUI.ServiceModel.Operations.SortedSet;
using ServiceStack;

namespace RedisAdminUI.ServiceInterface.SortedSet
{
	public class GetRangeFromSortedSetService : RedisServiceBase
	{
		public object Any(GetRangeFromSortedSet request)
		{
			var results = !request.SortDescending
				? Redis.GetRangeFromSortedSet(request.Id, request.FromRank, request.ToRank)
				: Redis.GetRangeFromSortedSetDesc(request.Id, request.FromRank, request.ToRank);

			return new GetRangeFromSortedSetResponse
	       	{
				Items = new ArrayOfString(results)
	       	};
		}
	}
}