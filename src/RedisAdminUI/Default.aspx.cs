using System;
using RedisAdminUI.ServiceInterface;
using ServiceStack;

namespace RedisWebServices
{
	public partial class _Default : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			Response.Redirect(HostContext.Resolve<AppConfig>().DefaultRedirectPath);
		}
	}
}