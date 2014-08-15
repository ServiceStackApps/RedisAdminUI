using System.Runtime.Serialization;
using ServiceStack.Model;
using ServiceStack;

namespace RedisAdminUI.ServiceModel.Operations.List
{
	[DataContract]
	public class RemoveEndFromList
		: IHasStringId
	{
		[DataMember]
		public string Id { get; set; }
	}

	[DataContract]
	public class RemoveEndFromListResponse
	{
		public RemoveEndFromListResponse()
		{
			this.ResponseStatus = new ResponseStatus();
		}

		[DataMember]
		public string Item { get; set; }

		[DataMember]
		public ResponseStatus ResponseStatus { get; set; }
	}
}