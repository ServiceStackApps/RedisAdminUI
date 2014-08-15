using System.Runtime.Serialization;
using ServiceStack.Model;
using ServiceStack;

namespace RedisAdminUI.ServiceModel.Operations.Set
{
	[DataContract]
	public class SetContainsItem
		: IHasStringId
	{
		[DataMember]
		public string Id { get; set; }

		[DataMember]
		public string Item { get; set; }
	}

	[DataContract]
	public class SetContainsItemResponse
	{
		public SetContainsItemResponse()
		{
			this.ResponseStatus = new ResponseStatus();
		}

		[DataMember] 
		public bool Result { get; set; }

		[DataMember]
		public ResponseStatus ResponseStatus { get; set; }
	}
}