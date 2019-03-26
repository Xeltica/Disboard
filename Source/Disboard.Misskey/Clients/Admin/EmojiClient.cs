using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Disboard.Extensions;
using Disboard.Misskey.Models;

namespace Disboard.Misskey.Clients.Admin
{
	public class EmojiClient : MisskeyApiClient
	{
		protected internal EmojiClient(MisskeyClient client) : base(client, "admin/emoji") { }

		public async Task<List<Emoji>> ListAsync(string host = null)
		{
			var parameters = new List<KeyValuePair<string, object>>();
			parameters.AddIfValidValue("host", host);
			return await PostAsync<List<Emoji>>("/list", parameters).Stay();
		}
		public async Task AddAsync(string name, string url, List<string> aliases)
		{
			var parameters = new List<KeyValuePair<string, object>>();
			parameters.AddIfValidValue("name", name);
			parameters.AddIfValidValue("url", url);
			parameters.AddIfValidValue("aliases", aliases);
			await PostAsync("/add", parameters).Stay();
		}
	}
}
