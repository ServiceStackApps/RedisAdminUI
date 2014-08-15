using System.Runtime.Serialization;
using ServiceStack;
using ServiceStack.Model;

namespace RedisAdminUI.ServiceModel.Operations.List
{
	[DataContract]
	public class GetRangeFromList
		: IHasStringId
	{
		[DataMember]
		public string Id { get; set; }

		[DataMember]
		public int StartingFrom { get; set; }

		[DataMember]
		public int EndingAt { get; set; }
	}

	[DataContract]
	public class GetRangeFromListResponse
	{
		public GetRangeFromListResponse()
		{
			this.ResponseStatus = new ResponseStatus();

			this.Items = new ArrayOfString();
		}

		[DataMember]
		public ArrayOfString Items { get; set; }

		[DataMember]
		public ResponseStatus ResponseStatus { get; set; }
	}
}