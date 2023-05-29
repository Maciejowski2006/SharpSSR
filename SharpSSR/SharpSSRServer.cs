using SAPI;
using SharpSSR.StaticContent;

namespace SharpSSR
{
	public class SharpSsrServer
	{
		private static Server sapi = new();
		protected static void Start()
		{
			sapi.MountEndpoint(new Styles());
			sapi.Start();
		}
		
		protected static void MountRoute(IRoute route)
		{
			sapi.MountEndpoint(route);
		}
	}
}