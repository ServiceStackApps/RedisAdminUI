using System;
using System.Runtime.Serialization;
using ServiceStack;

namespace RedisAdminUI.ServiceModel.Operations.Common
{
	[DataContract]
	public class GetTimeToLive
	{
		[DataMember] 
		public string Key { get; set; }
	}

	[DataContract]
	public class GetTimeToLiveResponse
	{
		public GetTimeToLiveResponse()
		{
			this.ResponseStatus = new ResponseStatus();
		}

		[DataMember] 
		public TimeSpan TimeRemaining { get; set; }

		[DataMember]
		public ResponseStatus ResponseStatus { get; set; }
	}
}