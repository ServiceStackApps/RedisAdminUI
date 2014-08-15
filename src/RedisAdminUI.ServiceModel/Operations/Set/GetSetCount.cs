using System.Runtime.Serialization;
using ServiceStack.Model;
using ServiceStack;

namespace RedisAdminUI.ServiceModel.Operations.Set
{
	[DataContract]
	public class GetSetCount
		: IHasStringId
	{
		[DataMember] 
		public string Id { get; set; }
	}

	[DataContract]
	public class GetSetCountResponse
	{
		public GetSetCountResponse()
		{
			this.ResponseStatus = new ResponseStatus();
		}

		[DataMember] 
		public long Count { get; set; }

		[DataMember]
		public ResponseStatus ResponseStatus { get; set; }
	}
}