using RedisAdminUI.ServiceModel.Operations.Set;
using ServiceStack;

namespace RedisAdminUI.ServiceInterface.Set
{
	public class GetUnionFromSetsService : RedisServiceBase
	{
		public object Any(GetUnionFromSets request)
		{
			return new GetUnionFromSetsResponse
	       	{
	       		Items = new ArrayOfString(Redis.GetUnionFromSets(request.SetIds.ToArray()))
	       	};
		}
	}
}