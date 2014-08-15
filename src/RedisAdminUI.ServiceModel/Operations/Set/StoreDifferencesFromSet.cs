using System.Collections.Generic;
using System.Runtime.Serialization;
using ServiceStack.Model;
using ServiceStack;

namespace RedisAdminUI.ServiceModel.Operations.Set
{
	[DataContract]
	public class StoreDifferencesFromSet
		: IHasStringId
	{
		public StoreDifferencesFromSet()
		{
			this.SetIds = new List<string>();
		}

		[DataMember]
		public string Id { get; set; }

		[DataMember]
		public string FromSetId { get; set; }

		[DataMember]
		public List<string> SetIds { get; set; }
	}

	[DataContract]
	public class StoreDifferencesFromSetResponse
	{
		public StoreDifferencesFromSetResponse()
		{
			this.ResponseStatus = new ResponseStatus();
		}

		[DataMember]
		public ResponseStatus ResponseStatus { get; set; }
	}
}