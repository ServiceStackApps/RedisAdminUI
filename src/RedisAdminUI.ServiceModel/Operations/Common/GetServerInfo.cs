using System.Runtime.Serialization;
using RedisAdminUI.ServiceModel.Types;
using ServiceStack;

namespace RedisAdminUI.ServiceModel.Operations.Common
{
	[DataContract]
	public class GetServerInfo
	{
	}

	[DataContract]
	public class GetServerInfoResponse
	{
		public GetServerInfoResponse()
		{
			this.ResponseStatus = new ResponseStatus();
		}

		[DataMember]
		public ArrayOfKeyValuePair ServerInfo { get; set; }

		[DataMember]
		public ResponseStatus ResponseStatus { get; set; }
	}
}