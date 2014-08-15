using System.Runtime.Serialization;
using ServiceStack;

namespace RedisAdminUI.ServiceModel.Operations.Common
{
	[DataContract]
	public class GetAllKeys
	{
	}

	[DataContract]
	public class GetAllKeysResponse
	{
		public GetAllKeysResponse()
		{
			this.ResponseStatus = new ResponseStatus();
			this.Keys = new ArrayOfString();
		}

		[DataMember] 
		public ArrayOfString Keys { get; set; }

		[DataMember]
		public ResponseStatus ResponseStatus { get; set; }
	}
}