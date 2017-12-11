using System;
using Funq;
using RedisAdminUI.ServiceInterface;
using RedisAdminUI.ServiceInterface.Admin;
using ServiceStack;
using ServiceStack.Configuration;
using ServiceStack.Logging;
using ServiceStack.Redis;

namespace RedisWebServices
{
	/// <summary>
	/// Configured AppHost to run inside an ASP.NET webserver.
	/// </summary>
	public class AppHost 
		: AppHostBase
	{
		private static ILog log;

		public AppHost()
			: base("Redis Web Services", typeof(PingService).Assembly)
		{
			LogManager.LogFactory = new DebugLogFactory();
			log = LogManager.GetLogger(typeof (AppHost));
		}

		public override void Configure(Container container)
		{
			container.Register(c => new AppConfig(new AppSettings()));
			var config = container.Resolve<AppConfig>();

			var redisHosts = new[] { config.RedisHostAddress };
			container.Register<IRedisClientsManager>(c =>
				new BasicRedisClientManager(redisHosts, redisHosts, config.RedisDb));

			log.InfoFormat("AppHost Configured: " + DateTime.Now);
		}
	}
}