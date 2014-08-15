using Funq;
using RedisAdminUI.ServiceInterface;
using RedisAdminUI.ServiceInterface.Admin;
using ServiceStack;
using ServiceStack.Configuration;
using ServiceStack.Redis;

namespace RedisWebServices.Tests
{
	public class TestHost
		: AppHostBase
	{
		public TestHost()
			: base("Redis Web Services", typeof(PingService).Assembly)
		{
		}

		public override void Configure(Container container)
		{
			container.Register(c => new AppConfig(new AppSettings()));
			var config = container.Resolve<AppConfig>();

			container.Register<IRedisClientsManager>(c =>
				new BasicRedisClientManager(config.RedisHostAddress));
		}
	}
}
