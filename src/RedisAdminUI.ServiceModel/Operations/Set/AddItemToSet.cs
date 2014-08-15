using System.Runtime.Serialization;
using ServiceStack.Model;
using ServiceStack;

namespace RedisAdminUI.ServiceModel.Operations.Set
{
	[DataContract]
	public class AddItemToSet
		: IHasStringId
	{
		[DataMember] 
		public string Id { get; set; }

		[DataMember]
		public string Item { get; set; }
	}

	[DataContract]
	public class AddItemToSetResponse
	{
		public AddItemToSetResponse()
		{
			this.ResponseStatus = new ResponseStatus();
		}

		[DataMember]
		public ResponseStatus ResponseStatus { get; set; }
	}
}