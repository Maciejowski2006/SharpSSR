
using Wolf;
using Index = WolfTesting.Routes.Index;

namespace WolfTesting
{
	public class WolfServerTesting : WolfServer
	{
		public static void Main(string[] args)
		{
			MountRoute(new Index());
			Start();
		}
	}
}
