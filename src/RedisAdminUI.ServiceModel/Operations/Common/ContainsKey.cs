using System.Runtime.Serialization;
using ServiceStack;

namespace RedisAdminUI.ServiceModel.Operations.Common
{
	[DataContract]
	public class ContainsKey
	{
		[DataMember] 
		public string Key { get; set; }
	}

	[DataContract]
	public class ContainsKeyResponse
	{
		public ContainsKeyResponse()
		{
			this.ResponseStatus = new ResponseStatus();
		}

		[DataMember] 
		public bool Result { get; set; }

		[DataMember]
		public ResponseStatus ResponseStatus { get; set; }
	}
}