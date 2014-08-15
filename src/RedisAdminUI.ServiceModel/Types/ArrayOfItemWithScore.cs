using System.Collections.Generic;
using System.Runtime.Serialization;

namespace RedisAdminUI.ServiceModel.Types
{
	[CollectionDataContract(ItemName = "ItemWithScore")]
	public class ArrayOfItemWithScore : List<ItemWithScore>
	{
		public ArrayOfItemWithScore() { }
		public ArrayOfItemWithScore(IEnumerable<ItemWithScore> collection) : base(collection) { }
	}
}