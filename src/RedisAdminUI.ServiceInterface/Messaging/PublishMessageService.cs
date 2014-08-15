using RedisAdminUI.ServiceModel.Operations.Messaging;

namespace RedisAdminUI.ServiceInterface.Messaging
{
	public class PublishMessageService : RedisServiceBase
	{
		public object Any(PublishMessage request)
		{
			Redis.PublishMessage(request.ToChannel, request.Message);

			return new PublishMessageResponse();
		}
	}
}