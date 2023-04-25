using System.Net;
using SAPI.Endpoints;

namespace Wolf
{
	public interface IRoute : IEndpoint
	{
		public string template { get; }
		/// <summary>
		/// List of partials to be included
		/// <param name="key">friendly name used in main .hbs file</param>
		/// <param name="value">name for the partial file inside /partials folder</param>
		/// </summary>
		public Dictionary<string, string>? partials { get; }
	}
}
