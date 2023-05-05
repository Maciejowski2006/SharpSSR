using SAPI;
using Wolf.StaticContent;

namespace Wolf
{
	public class WolfServer
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