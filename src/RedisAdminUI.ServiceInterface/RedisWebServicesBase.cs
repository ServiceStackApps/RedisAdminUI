using ServiceStack;
using ServiceStack.Redis;

namespace RedisAdminUI.ServiceInterface
{
	/// <summary>
	/// Common base class for all Redis Web Services
	/// </summary>
	public abstract class RedisServiceBase : Service
	{
        public const string ResponseDtoSuffix = "Response";

		public AppConfig Config { get; set; }

	    public IRedisNativeClient RedisNative
	    {
	        get { return (IRedisNativeClient) Redis; }
	    }
	}
}