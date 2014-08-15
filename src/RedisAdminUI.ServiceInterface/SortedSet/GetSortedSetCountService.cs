using RedisAdminUI.ServiceModel.Operations.SortedSet;

namespace RedisAdminUI.ServiceInterface.SortedSet
{
	public class GetSortedSetCountService : RedisServiceBase
	{
		public object Any(GetSortedSetCount request)
		{
			return new GetSortedSetCountResponse
	       	{
				Count = Redis.GetSortedSetCount(request.Id)
	       	};
		}
	}
}