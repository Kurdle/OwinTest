using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(OwinTest.Startup))]

namespace OwinTest
{
	public class Startup
	{
		public void Configuration(IAppBuilder app)
		{
			app.UseWelcomePage();
		}
	}
}