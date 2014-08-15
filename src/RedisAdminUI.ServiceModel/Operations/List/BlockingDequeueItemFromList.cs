using System;
using System.Runtime.Serialization;
using ServiceStack.Model;
using ServiceStack;

namespace RedisAdminUI.ServiceModel.Operations.List
{
	[DataContract]
	public class BlockingDequeueItemFromList
		: IHasStringId
	{
		[DataMember]
		public string Id { get; set; }

		[DataMember]
		public TimeSpan? TimeOut { get; set; }
	}

	[DataContract]
	public class BlockingDequeueItemFromListResponse
	{
		public BlockingDequeueItemFromListResponse()
		{
			this.ResponseStatus = new ResponseStatus();
		}

		[DataMember]
		public string Item { get; set; }

		[DataMember]
		public ResponseStatus ResponseStatus { get; set; }
	}
}