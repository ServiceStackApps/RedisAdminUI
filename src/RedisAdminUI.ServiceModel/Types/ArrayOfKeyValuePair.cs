using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

namespace RedisAdminUI.ServiceModel.Types
{
	[CollectionDataContract(ItemName = "KeyValuePair")]
	public class ArrayOfKeyValuePair 
		: List<KeyValuePair>
	{
		public ArrayOfKeyValuePair() { }
		public ArrayOfKeyValuePair(IEnumerable<KeyValuePair> collection) : base(collection) { }
		public ArrayOfKeyValuePair(IEnumerable<KeyValuePair<string, string>> collection) 
			: base(collection.ToList().ConvertAll(x => new KeyValuePair(x.Key, x.Value))) { }
	}
}