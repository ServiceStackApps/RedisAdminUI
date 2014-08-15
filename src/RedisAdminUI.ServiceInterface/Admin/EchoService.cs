using RedisAdminUI.ServiceModel.Operations.Common;

namespace RedisAdminUI.ServiceInterface.Admin
{
	public class EchoService : RedisServiceBase
	{
	    public object Any(Echo request)
		{
			return new EchoResponse
	       	{
	       		Text = RedisNative.Echo(request.Text)
	       	};
		}
	}
}