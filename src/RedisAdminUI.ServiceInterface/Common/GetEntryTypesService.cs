using RedisAdminUI.ServiceModel.Operations.Common;
using RedisAdminUI.ServiceModel.Types;

namespace RedisAdminUI.ServiceInterface.Common
{
	public class GetEntryTypesService
		: RedisServiceBase
	{
		public object Any(GetEntryTypes request)
		{
			var response = new GetEntryTypesResponse();
            foreach (var key in request.Keys)
            {
                var keyType = Redis.GetEntryType(key);
                response.KeyTypes.Add(new KeyValuePair(key, keyType.ToString()));
            }

			return response;
		}
	}
}