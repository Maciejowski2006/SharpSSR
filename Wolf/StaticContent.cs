using System.Net;
using SAPI.Endpoints;

namespace Wolf
{
	public class StaticContent : IEndpoint
	{
		public string url { get; set; } = "styles/:file";
		public Method method { get; set; } = Method.GET;
		public void Task(ref HttpListenerRequest request, ref HttpListenerResponse response, Dictionary<string, string> parameters)
		{
			SAPI.Utilities.StaticContent.StaticContent.HostDirectory(Path.Combine(Environment.CurrentDirectory, "styles"), parameters, ref response);
		}
	}
}
