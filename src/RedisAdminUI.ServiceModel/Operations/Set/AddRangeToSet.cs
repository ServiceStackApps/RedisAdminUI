using System.Collections.Generic;
using System.Runtime.Serialization;
using ServiceStack.Model;
using ServiceStack;

namespace RedisAdminUI.ServiceModel.Operations.Set
{
	[DataContract]
	public class AddRangeToSet
		: IHasStringId
	{
		public AddRangeToSet()
		{
			this.Items = new List<string>();
		}

		[DataMember] 
		public string Id { get; set; }

		[DataMember]
		public List<string> Items { get; set; }
	}

	[DataContract]
	public class AddRangeToSetResponse
	{
		public AddRangeToSetResponse()
		{
			this.ResponseStatus = new ResponseStatus();
		}

		[DataMember]
		public ResponseStatus ResponseStatus { get; set; }
	}
}