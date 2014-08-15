using RedisAdminUI.ServiceModel.Operations.List;

namespace RedisAdminUI.ServiceInterface.List
{
	public class GetListCountService : RedisServiceBase
	{
		public object Any(GetListCount request)
		{
			return new GetListCountResponse
			{
				Count = Redis.GetListCount(request.Id)
			};
		}
	}
}