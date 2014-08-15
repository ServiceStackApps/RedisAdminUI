using RedisAdminUI.ServiceModel.Operations.SortedSet;
using ServiceStack;

namespace RedisAdminUI.ServiceInterface.SortedSet
{
	public class AddRangeToSortedSetService : RedisServiceBase
	{
		public object Any(AddRangeToSortedSet request)
		{
			if (!request.Items.IsNullOrEmpty())
			{
				request.Items.ForEach(x => Redis.AddItemToSortedSet(request.Id, x.Item, x.Score));
			}

			return new AddRangeToSortedSetResponse();
		}
	}
}