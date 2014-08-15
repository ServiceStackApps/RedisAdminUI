using RedisAdminUI.ServiceModel.Operations.Set;
using ServiceStack;

namespace RedisAdminUI.ServiceInterface.Set
{
	public class AddRangeToSetService : RedisServiceBase
	{
		public object Any(AddRangeToSet request)
		{
			if (!request.Items.IsNullOrEmpty())
			{
				request.Items.ForEach(x => Redis.AddItemToSet(request.Id, x));
			}

			return new AddRangeToSetResponse();
		}
	}
}