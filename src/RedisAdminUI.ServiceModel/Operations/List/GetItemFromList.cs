using System.Runtime.Serialization;
using ServiceStack.Model;
using ServiceStack;

namespace RedisAdminUI.ServiceModel.Operations.List
{
	[DataContract]
	public class GetItemFromList
		: IHasStringId
	{
		[DataMember]
		public string Id { get; set; }

		[DataMember]
		public int Index { get; set; }
	}

	[DataContract]
	public class GetItemFromListResponse
	{
		public GetItemFromListResponse()
		{
			this.ResponseStatus = new ResponseStatus();
		}

		[DataMember] 
		public string Item { get; set; }

		[DataMember]
		public ResponseStatus ResponseStatus { get; set; }
	}
}