using RedisAdminUI.ServiceModel.Operations.List;
using ServiceStack;

namespace RedisAdminUI.ServiceInterface.List
{
	public class GetRangeFromListService
		: RedisServiceBase
	{
		public object Any(GetRangeFromList request)
		{
			return new GetRangeFromListResponse
			{
				Items = new ArrayOfString(
					Redis.GetRangeFromList(request.Id, request.StartingFrom, request.EndingAt)
				)
			};
		}
	}
}