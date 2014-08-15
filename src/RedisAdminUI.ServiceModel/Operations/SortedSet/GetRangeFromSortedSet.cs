using System.Runtime.Serialization;
using ServiceStack;
using ServiceStack.Model;

namespace RedisAdminUI.ServiceModel.Operations.SortedSet
{
	[DataContract]
	public class GetRangeFromSortedSet
		: IHasStringId
	{
		[DataMember]
		public string Id { get; set; }

		[DataMember]
		public int FromRank { get; set; }

		[DataMember]
		public int ToRank { get; set; }

		[DataMember]
		public bool SortDescending { get; set; }
	}

	[DataContract]
	public class GetRangeFromSortedSetResponse
	{
		public GetRangeFromSortedSetResponse()
		{
			this.ResponseStatus = new ResponseStatus();

			this.Items = new ArrayOfString();
		}

		[DataMember]
		public ArrayOfString Items { get; set; }

		[DataMember]
		public ResponseStatus ResponseStatus { get; set; }
	}
}