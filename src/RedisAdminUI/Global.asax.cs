using System;
using ServiceStack;

namespace RedisWebServices
{
	public class Global : System.Web.HttpApplication
	{
		protected void Application_Start(object sender, EventArgs e)
		{
            var appHost = new AppHost();
			appHost.Init();
		}
	}
}