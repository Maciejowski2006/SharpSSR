using System.Collections.ObjectModel;
using System.Net;
using HandlebarsDotNet;
using SAPI.Utilities;

namespace Wolf.Utilities.Templates
{
	public class Templates
	{
		public static void RenderTemplate(in IRoute route, object data, ref HttpListenerResponse response)
		{
			// Directories
			string templates = Path.Combine(Environment.CurrentDirectory, "templates");
			string partials = Path.Combine(Environment.CurrentDirectory, "partials");
			string mainFile = Path.Combine(templates, route.template);
			
			string content = File.ReadAllText(mainFile);
			
			// Handling partials
			if (route.partials != null)
				foreach (KeyValuePair<string, string> partial in route.partials)
				{
					string partialFile = Path.Combine(partials, partial.Value);
					string partialContent = File.ReadAllText(partialFile);
					Handlebars.RegisterTemplate(partial.Key, partialContent);
				}
			
			// Compile templates
			HandlebarsTemplate<object, object>? template = Handlebars.Compile(content);
			string result = template(data);
			
			SAPI.Utilities.Utilities.HtmlResponse(result, ref response);
		}
	}
}
