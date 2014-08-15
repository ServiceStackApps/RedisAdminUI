using System.Runtime.Serialization;
using ServiceStack;
using ServiceStack.Model;

namespace RedisAdminUI.ServiceModel.Operations.SortedSet
{
	[DataContract]
	public class GetAllItemsFromSortedSet
		: IHasStringId
	{
		[DataMember]
		public string Id { get; set; }
	}

	[DataContract]
	public class GetAllItemsFromSortedSetResponse
	{
		public GetAllItemsFromSortedSetResponse()
		{
			this.ResponseStatus = new ResponseStatus();

			this.Items = new ArrayOfString();
		}

		[DataMember]
		public ArrayOfString Items { get; set; }

		[DataMember]
		public ResponseStatus ResponseStatus { get; set; }
	}
}