
using SharpSSR;
using Index = SharpSSRTesting.Routes.Index;

namespace WolfTesting
{
	public class WolfServerTesting : SharpSsrServer
	{
		public static void Main()
		{
			MountRoute(new Index());
			Start();
		}
	}
}
