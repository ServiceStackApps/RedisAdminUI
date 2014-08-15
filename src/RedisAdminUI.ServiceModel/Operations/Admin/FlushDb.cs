using System.Runtime.Serialization;
using ServiceStack;

namespace RedisAdminUI.ServiceModel.Operations.Admin
{
	//[Service(EndpointAttributes.InternalNetworkAccess)]
	[DataContract]
	public class FlushDb
	{
		[DataMember]
		public int Db { get; set; }
	}

	[DataContract]
	public class FlushDbResponse
	{
		public FlushDbResponse()
		{
			this.ResponseStatus = new ResponseStatus();
		}

		[DataMember]
		public ResponseStatus ResponseStatus { get; set; }
	}
}