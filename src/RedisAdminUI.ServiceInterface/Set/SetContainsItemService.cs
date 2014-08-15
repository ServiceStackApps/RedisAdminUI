using RedisAdminUI.ServiceModel.Operations.Set;

namespace RedisAdminUI.ServiceInterface.Set
{
	public class SetContainsItemService : RedisServiceBase
	{
		public object Any(SetContainsItem request)
		{
			return new SetContainsItemResponse
	       	{
				Result = Redis.SetContainsItem(request.Id, request.Item)
	       	};
		}
	}
}