using System.Net;
using SAPI.Endpoints;
using SharpSSR;
using SharpSSR.Utilities.Templates;

namespace SharpSSRTesting.Routes
{
	public class Index : IRoute
	{

		public string url { get; set; } = "";
		public Method method { get; set; } = Method.GET;
		public string template { get; set; } = "index.hbs";
		public Dictionary<string, string>? partials { get; set; } = new()
		{
			{ "test", "test.hbs" }
		};

		public void Task(ref HttpListenerRequest request, ref HttpListenerResponse response, Dictionary<string, string> parameters)
		{
			
			
			Templates.RenderTemplate(this, new
			{
				h3 = "bruh",
			}, ref response);
		}
	}
}
