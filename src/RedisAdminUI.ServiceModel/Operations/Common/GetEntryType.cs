using System.Runtime.Serialization;
using RedisAdminUI.ServiceModel.Types;
using ServiceStack;
using ServiceStack.DataAnnotations;

namespace RedisAdminUI.ServiceModel.Operations.Common
{
	[DataContract]
	public class GetEntryType
	{
		[DataMember] 
		public string Key { get; set; }
	}

	[DataContract]
	public class GetEntryTypeResponse
	{
		public GetEntryTypeResponse()
		{
			this.ResponseStatus = new ResponseStatus();
		}

		[References(typeof(KeyType))]
		[DataMember] 
		public string KeyType { get; set; }

		[DataMember]
		public ResponseStatus ResponseStatus { get; set; }
	}
}