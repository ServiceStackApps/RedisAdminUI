using RedisAdminUI.ServiceModel.Operations.List;
using ServiceStack;

namespace RedisAdminUI.ServiceInterface.List
{
	public class AddRangeToListService : RedisServiceBase
	{
		public object Any(AddRangeToList request)
		{
			if (!request.Items.IsNullOrEmpty())
			{
				request.Items.ForEach(x => Redis.AddItemToList(request.Id, x));
			}

			return new AddRangeToListResponse();
		}
	}
}