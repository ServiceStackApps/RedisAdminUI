using System.Runtime.Serialization;
using ServiceStack;

namespace RedisAdminUI.ServiceModel.Operations.Admin
{
	//[Service(EndpointAttributes.InternalNetworkAccess)]
	[DataContract]
	public class SlaveOf
	{
		[DataMember]
		public string Host { get; set; }

		[DataMember]
		public int Port { get; set; }

		[DataMember]
		public bool NoOne { get; set; }
	}

	[DataContract]
	public class SlaveOfResponse
	{
		public SlaveOfResponse()
		{
			this.ResponseStatus = new ResponseStatus();
		}

		[DataMember]
		public ResponseStatus ResponseStatus { get; set; }
	}
}