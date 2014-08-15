using System.Runtime.Serialization;
using ServiceStack;

namespace RedisAdminUI.ServiceModel.Operations.Common
{
	[DataContract]
	public class GetSortedEntryValues
	{
		[DataMember]
		public string Key { get; set; }

		[DataMember]
		public int StartingFrom { get; set; }

		[DataMember]
		public int EndingAt { get; set; }
	}

	[DataContract]
	public class GetSortedEntryValuesResponse
	{
		public GetSortedEntryValuesResponse()
		{
			this.ResponseStatus = new ResponseStatus();

			this.Values = new ArrayOfString();
		}

		[DataMember] 
		public ArrayOfString Values { get; set; }

		[DataMember]
		public ResponseStatus ResponseStatus { get; set; }
	}
}