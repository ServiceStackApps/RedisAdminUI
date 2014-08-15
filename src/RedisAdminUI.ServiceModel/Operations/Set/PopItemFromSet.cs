using System.Runtime.Serialization;
using ServiceStack.Model;
using ServiceStack;

namespace RedisAdminUI.ServiceModel.Operations.Set
{
	[DataContract]
	public class PopItemFromSet
		: IHasStringId
	{
		[DataMember] 
		public string Id { get; set; }
	}

	[DataContract]
	public class PopItemFromSetResponse
	{
		public PopItemFromSetResponse()
		{
			this.ResponseStatus = new ResponseStatus();
		}

		[DataMember] 
		public string Item { get; set; }

		[DataMember]
		public ResponseStatus ResponseStatus { get; set; }
	}
}