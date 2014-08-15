using System.Runtime.Serialization;
using ServiceStack;

namespace RedisAdminUI.ServiceModel.Operations.Common
{
	[DataContract]
	public class Ping
	{
	}

	[DataContract]
	public class PingResponse
	{
		public PingResponse()
		{
			this.ResponseStatus = new ResponseStatus();
		}

		[DataMember] 
		public bool Result { get; set; }

		[DataMember]
		public ResponseStatus ResponseStatus { get; set; }
	}
}