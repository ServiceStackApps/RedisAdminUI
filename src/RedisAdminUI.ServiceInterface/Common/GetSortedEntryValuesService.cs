using RedisAdminUI.ServiceModel.Operations.Common;
using ServiceStack;

namespace RedisAdminUI.ServiceInterface.Common
{
	public class GetSortedEntryValuesService : RedisServiceBase
	{
		public object Any(GetSortedEntryValues request)
		{
			return new GetSortedEntryValuesResponse
			{
				Values = new ArrayOfString(
					Redis.GetSortedEntryValues(request.Key,
						request.StartingFrom, request.EndingAt)
				)
			};
		}
	}
}