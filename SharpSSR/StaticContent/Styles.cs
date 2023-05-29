using System.Net;
using SAPI.Endpoints;
using _StaticContent = SAPI.Utilities.StaticContent;

namespace SharpSSR.StaticContent
{
	public class Styles : IEndpoint
	{
		public string url { get; set; } = "styles/{recursive}";
		public Method method { get; set; } = Method.GET;
		public void Task(ref HttpListenerRequest request, ref HttpListenerResponse response, Dictionary<string, string> parameters)
		{
			_StaticContent.HostDirectoryRecursively(Path.Combine(Environment.CurrentDirectory, "src", "styles"),url, ref request, ref response);
		}
	}
}
