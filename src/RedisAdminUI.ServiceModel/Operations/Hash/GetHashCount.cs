using System.Runtime.Serialization;
using ServiceStack;
using ServiceStack.Model;

namespace RedisAdminUI.ServiceModel.Operations.Hash
{
	[DataContract]
	public class GetHashCount
		: IHasStringId
	{
		[DataMember]
		public string Id { get; set; }
	}

	[DataContract]
	public class GetHashCountResponse
	{
		public GetHashCountResponse()
		{
			this.ResponseStatus = new ResponseStatus();
		}

		[DataMember]
		public long Count { get; set; }

		[DataMember]
		public ResponseStatus ResponseStatus { get; set; }
	}
}