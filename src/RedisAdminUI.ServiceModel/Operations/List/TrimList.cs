using System.Runtime.Serialization;
using ServiceStack.Model;
using ServiceStack;

namespace RedisAdminUI.ServiceModel.Operations.List
{
	[DataContract]
	public class TrimList
		: IHasStringId
	{
		[DataMember]
		public string Id { get; set; }

		[DataMember]
		public int KeepStartingFrom { get; set; }

		[DataMember]
		public int KeepEndingAt { get; set; }
	}

	[DataContract]
	public class TrimListResponse
	{
		public TrimListResponse()
		{
			this.ResponseStatus = new ResponseStatus();
		}

		[DataMember]
		public ResponseStatus ResponseStatus { get; set; }
	}
}