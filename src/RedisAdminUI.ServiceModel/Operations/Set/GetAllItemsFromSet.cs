using System.Runtime.Serialization;
using ServiceStack;
using ServiceStack.Model;

namespace RedisAdminUI.ServiceModel.Operations.Set
{
	[DataContract]
	public class GetAllItemsFromSet
		: IHasStringId
	{
		[DataMember] 
		public string Id { get; set; }
	}

	[DataContract]
	public class GetAllItemsFromSetResponse
	{
		public GetAllItemsFromSetResponse()
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