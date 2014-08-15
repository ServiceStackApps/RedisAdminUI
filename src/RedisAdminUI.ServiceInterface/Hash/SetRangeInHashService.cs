using System.Collections.Generic;
using RedisAdminUI.ServiceModel.Operations.Hash;

namespace RedisAdminUI.ServiceInterface.Hash
{
	public class SetRangeInHashService : RedisServiceBase
	{
		public object Any(SetRangeInHash request)
		{
			var map = new Dictionary<string, string>();
			request.KeyValuePairs.ForEach(kvp => map[kvp.Key] = kvp.Value);

			Redis.SetRangeInHash(request.Id, map);

			return new SetRangeInHashResponse();
		}
	}
}