using System.Runtime.Serialization;
using ServiceStack;
using ServiceStack.Model;

namespace RedisAdminUI.ServiceModel.Operations.Hash
{
	[DataContract]
	public class GetHashValues
		: IHasStringId
	{
		[DataMember]
		public string Id { get; set; }
	}

	[DataContract]
	public class GetHashValuesResponse
	{
		public GetHashValuesResponse()
		{
			this.ResponseStatus = new ResponseStatus();

			this.Values = new ArrayOfString();
		}

		[DataMember]
		public ArrayOfString Values { get; set; }

		[DataMember]
		public ResponseStatus ResponseStatus { get; set; }
	}
}