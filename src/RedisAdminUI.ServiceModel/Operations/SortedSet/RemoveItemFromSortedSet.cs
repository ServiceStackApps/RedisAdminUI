using System.Runtime.Serialization;
using ServiceStack.Model;
using ServiceStack;

namespace RedisAdminUI.ServiceModel.Operations.SortedSet
{
	[DataContract]
	public class RemoveItemFromSortedSet
		: IHasStringId
	{
		[DataMember]
		public string Id { get; set; }

		[DataMember]
		public string Item { get; set; }
	}

	[DataContract]
	public class RemoveItemFromSortedSetResponse
	{
		public RemoveItemFromSortedSetResponse()
		{
			this.ResponseStatus = new ResponseStatus();
		}

		[DataMember]
		public bool Result { get; set; }

		[DataMember]
		public ResponseStatus ResponseStatus { get; set; }
	}
}