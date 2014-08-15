using System.Runtime.Serialization;
using ServiceStack.Model;
using ServiceStack;

namespace RedisAdminUI.ServiceModel.Operations.SortedSet
{
	[DataContract]
	public class PopItemWithLowestScoreFromSortedSet
		: IHasStringId
	{
		[DataMember]
		public string Id { get; set; }
	}

	[DataContract]
	public class PopItemWithLowestScoreFromSortedSetResponse
	{
		public PopItemWithLowestScoreFromSortedSetResponse()
		{
			this.ResponseStatus = new ResponseStatus();
		}

		[DataMember]
		public string Item { get; set; }

		[DataMember]
		public ResponseStatus ResponseStatus { get; set; }
	}
}