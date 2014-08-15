using RedisAdminUI.ServiceModel.Operations.Set;

namespace RedisAdminUI.ServiceInterface.Set
{
	public class MoveBetweenSetsService : RedisServiceBase
	{
		public object Any(MoveBetweenSets request)
		{
		    Redis.MoveBetweenSets(request.FromSetId, request.ToSetId, request.Item);

			return new MoveBetweenSetsResponse();
		}
	}
}