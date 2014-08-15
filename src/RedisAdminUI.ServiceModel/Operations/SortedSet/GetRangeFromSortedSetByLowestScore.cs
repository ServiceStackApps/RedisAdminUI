using System.Runtime.Serialization;
using ServiceStack.Model;
using ServiceStack;

namespace RedisAdminUI.ServiceModel.Operations.SortedSet
{
	[DataContract]
	public class GetRangeFromSortedSetByLowestScore
		: IHasStringId
	{
		[DataMember]
		public string Id { get; set; }

		[DataMember]
		public double FromScore { get; set; }

		[DataMember]
		public double ToScore { get; set; }

		[DataMember]
		public int? Skip { get; set; }

		[DataMember]
		public int? Take { get; set; }
	}

	[DataContract]
	public class GetRangeFromSortedSetByLowestScoreResponse
	{
		public GetRangeFromSortedSetByLowestScoreResponse()
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