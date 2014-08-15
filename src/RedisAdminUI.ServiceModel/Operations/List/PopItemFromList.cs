using System.Runtime.Serialization;
using ServiceStack.Model;
using ServiceStack;

namespace RedisAdminUI.ServiceModel.Operations.List
{
	[DataContract]
	public class PopItemFromList
		: IHasStringId
	{
		[DataMember]
		public string Id { get; set; }
	}

	[DataContract]
	public class PopItemFromListResponse
	{
		public PopItemFromListResponse()
		{
			this.ResponseStatus = new ResponseStatus();
		}

		[DataMember]
		public string Item { get; set; }

		[DataMember]
		public ResponseStatus ResponseStatus { get; set; }
	}
}