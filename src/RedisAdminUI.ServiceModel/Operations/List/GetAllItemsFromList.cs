using System.Runtime.Serialization;
using ServiceStack;
using ServiceStack.Model;

namespace RedisAdminUI.ServiceModel.Operations.List
{
	[DataContract]
	public class GetAllItemsFromList
		: IHasStringId
	{
		[DataMember] 
		public string Id { get; set; }
	}

	[DataContract]
	public class GetAllItemsFromListResponse
	{
		public GetAllItemsFromListResponse()
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