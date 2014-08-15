using RedisAdminUI.ServiceModel.Operations.SortedSet;

namespace RedisAdminUI.ServiceInterface.SortedSet
{
	public class RemoveRangeFromSortedSetService : RedisServiceBase
	{
		public object Any(RemoveRangeFromSortedSet request)
		{
			return new RemoveRangeFromSortedSetResponse
	       	{
				ItemsRemovedCount = Redis.RemoveRangeFromSortedSet(
					request.Id, request.FromRank, request.ToRank)
	       	};
		}
	}
}