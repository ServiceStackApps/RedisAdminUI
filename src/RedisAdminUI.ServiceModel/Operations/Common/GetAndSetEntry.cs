using System.Runtime.Serialization;
using ServiceStack;

namespace RedisAdminUI.ServiceModel.Operations.Common
{
	[DataContract]
	public class GetAndSetEntry
	{
		[DataMember]
		public string Key { get; set; }

		[DataMember]
		public string Value { get; set; }
	}

	[DataContract]
	public class GetAndSetEntryResponse
	{
		public GetAndSetEntryResponse()
		{
			this.ResponseStatus = new ResponseStatus();
		}

		[DataMember] 
		public string ExistingValue { get; set; }

		[DataMember]
		public ResponseStatus ResponseStatus { get; set; }
	}
}