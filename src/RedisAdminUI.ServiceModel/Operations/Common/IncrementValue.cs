using System.Runtime.Serialization;
using ServiceStack;

namespace RedisAdminUI.ServiceModel.Operations.Common
{
	[DataContract]
	public class IncrementValue
	{
		[DataMember]
		public string Key { get; set; }

		[DataMember]
		public int? IncrementBy { get; set; }

	}

	[DataContract]
	public class IncrementValueResponse
	{
		public IncrementValueResponse()
		{
			this.ResponseStatus = new ResponseStatus();
		}

		[DataMember] 
		public long Value { get; set; }

		[DataMember]
		public ResponseStatus ResponseStatus { get; set; }
	}
}