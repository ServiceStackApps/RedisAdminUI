using System.Collections.Generic;
using System.Runtime.Serialization;
using RedisAdminUI.ServiceModel.Types;
using ServiceStack.Model;
using ServiceStack;

namespace RedisAdminUI.ServiceModel.Operations.Hash
{
	[DataContract]
	public class GetAllEntriesFromHash
		: IHasStringId
	{
		[DataMember]
		public string Id { get; set; }
	}

	[DataContract]
	public class GetAllEntriesFromHashResponse
	{
		public GetAllEntriesFromHashResponse()
		{
			this.ResponseStatus = new ResponseStatus();

			this.KeyValuePairs = new ArrayOfKeyValuePair();
		}

		[DataMember]
		public ArrayOfKeyValuePair KeyValuePairs { get; set; }

		[DataMember]
		public ResponseStatus ResponseStatus { get; set; }
	}
}