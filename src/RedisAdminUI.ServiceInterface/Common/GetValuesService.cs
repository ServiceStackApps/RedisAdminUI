using RedisAdminUI.ServiceModel.Operations.Common;
using ServiceStack;

namespace RedisAdminUI.ServiceInterface.Common
{
	public class GetValuesService : RedisServiceBase
	{
		public object Any(GetValues request)
		{
			var response = new GetValuesResponse
			{
				Values = new ArrayOfString(
					Redis.GetValues(request.Keys)
				)
			};

			return response;
		}
	}
}