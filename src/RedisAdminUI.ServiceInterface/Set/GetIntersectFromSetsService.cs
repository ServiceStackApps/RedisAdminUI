using RedisAdminUI.ServiceModel.Operations.Set;
using ServiceStack;

namespace RedisAdminUI.ServiceInterface.Set
{
	public class GetIntersectFromSetsService : RedisServiceBase
	{
		public object Any(GetIntersectFromSets request)
		{
			return new GetIntersectFromSetsResponse
	       	{
	       		Items = new ArrayOfString(Redis.GetIntersectFromSets(request.SetIds.ToArray()))
	       	};
		}
	}
}