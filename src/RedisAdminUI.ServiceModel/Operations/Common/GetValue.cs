using System.Runtime.Serialization;
using ServiceStack;

namespace RedisAdminUI.ServiceModel.Operations.Common
{
	[DataContract]
	public class GetValue
	{
		[DataMember] 
		public string Key { get; set; }
	}

	[DataContract]
	public class GetValueResponse
	{
		public GetValueResponse()
		{
			this.ResponseStatus = new ResponseStatus();
		}

		[DataMember] 
		public string Value { get; set; }

		[DataMember]
		public ResponseStatus ResponseStatus { get; set; }
	}
}