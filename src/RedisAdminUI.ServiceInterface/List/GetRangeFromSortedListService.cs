using RedisAdminUI.ServiceModel.Operations.List;
using ServiceStack;

namespace RedisAdminUI.ServiceInterface.List
{
	public class GetRangeFromSortedListService
		: RedisServiceBase
	{
		public object Any(GetRangeFromSortedList request)
		{
			var response = new GetRangeFromSortedListResponse
			{
				Items = new ArrayOfString(
					Redis.GetRangeFromSortedList(request.Id, request.StartingFrom, request.EndingAt)
				)
			};

			return response;
		}
	}
}