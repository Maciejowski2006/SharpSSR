
using Wolf;
using Index = WolfTesting.Routes.Index;

namespace WolfTesting
{
	public class WolfServerTesting : WolfServer
	{
		public static void Main()
		{
			MountRoute(new Index());
			Start();
		}
	}
}
