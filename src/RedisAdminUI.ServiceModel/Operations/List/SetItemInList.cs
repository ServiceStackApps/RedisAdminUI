using System.Runtime.Serialization;
using ServiceStack.Model;
using ServiceStack;

namespace RedisAdminUI.ServiceModel.Operations.List
{
	[DataContract]
	public class SetItemInList
		: IHasStringId
	{
		[DataMember]
		public string Id { get; set; }

		[DataMember]
		public int Index { get; set; }

		[DataMember]
		public string Item { get; set; }
	}

	[DataContract]
	public class SetItemInListResponse
	{
		public SetItemInListResponse()
		{
			this.ResponseStatus = new ResponseStatus();
		}

		[DataMember]
		public ResponseStatus ResponseStatus { get; set; }
	}
}