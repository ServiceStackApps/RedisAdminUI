using RedisAdminUI.ServiceModel.Operations.Set;

namespace RedisAdminUI.ServiceInterface.Set
{
	public class StoreDifferencesFromSetService : RedisServiceBase
	{
		public object Any(StoreDifferencesFromSet request)
		{
			Redis.StoreDifferencesFromSet(request.Id, request.FromSetId, request.SetIds.ToArray());

			return new StoreDifferencesFromSetResponse();
		}
	}
}