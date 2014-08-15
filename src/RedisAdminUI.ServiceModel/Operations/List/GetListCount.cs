using System.Runtime.Serialization;
using ServiceStack;
using ServiceStack.Model;

namespace RedisAdminUI.ServiceModel.Operations.List
{
	[DataContract]
	public class GetListCount
		: IHasStringId
	{
		[DataMember]
		public string Id { get; set; }
	}

	[DataContract]
	public class GetListCountResponse
	{
		public GetListCountResponse()
		{
			this.ResponseStatus = new ResponseStatus();
		}

		[DataMember]
		public long Count { get; set; }

		[DataMember]
		public ResponseStatus ResponseStatus { get; set; }
	}
}