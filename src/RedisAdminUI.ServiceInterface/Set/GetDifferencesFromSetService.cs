using RedisAdminUI.ServiceModel.Operations.Set;
using ServiceStack;

namespace RedisAdminUI.ServiceInterface.Set
{
	public class GetDifferencesFromSetService : RedisServiceBase
	{
		public object Any(GetDifferencesFromSet request)
		{
			return new GetDifferencesFromSetResponse
	       	{
	       		Items = new ArrayOfString(Redis.GetDifferencesFromSet(
					request.Id, request.SetIds.ToArray()))
	       	};
		}
	}
}