using System.Runtime.Serialization;
using ServiceStack;

namespace RedisAdminUI.ServiceModel.Operations.Common
{
	[DataContract]
	public class AppendToValue
	{
		[DataMember]
		public string Key { get; set; }

		[DataMember]
		public string Value { get; set; }
	}

	[DataContract]
	public class AppendToValueResponse
	{
		public AppendToValueResponse()
		{
			this.ResponseStatus = new ResponseStatus();
		}

		[DataMember] 
		public long ValueLength { get; set; }

		[DataMember]
		public ResponseStatus ResponseStatus { get; set; }
	}
}