using SAPI;

namespace Wolf
{
	public class WolfServer
	{
		private static Server sapi = new();
		protected static void Start()
		{
			sapi.MountEndpoint(new StaticContent());
			sapi.Start();
		}
		
		protected static void MountRoute(IRoute route)
		{
			sapi.MountEndpoint(route);
		}
	}
}