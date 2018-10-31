﻿using System.Collections.Generic;
using System.Threading.Tasks;

using Disboard.Clients;
using Disboard.Extensions;
using Disboard.Misskey.Models;

namespace Disboard.Misskey.Clients
{
    public class MuteClient : ApiClient<MisskeyClient>
    {
        protected internal MuteClient(MisskeyClient client) : base(client, "/api/mute") { }

        public async Task CreateAsync(string userId)
        {
            var parameters = new List<KeyValuePair<string, object>> {new KeyValuePair<string, object>("userId", userId)};
            await PostAsync("/create", parameters).Stay();
        }

        public async Task DeleteAsync(string userId)
        {
            var parameters = new List<KeyValuePair<string, object>> {new KeyValuePair<string, object>("userId", userId)};
            await PostAsync("/delete", parameters).Stay();
        }

        public async Task<MuteList> ListAsync(bool? iknow = null, int? limit = null, string cursor = null)
        {
            var parameters = new List<KeyValuePair<string, object>>();
            parameters.AddIfValidValue("iknow", iknow);
            parameters.AddIfValidValue("limit", limit);
            parameters.AddIfValidValue("cursor", cursor);

            return await PostAsync<MuteList>("/list", parameters).Stay();
        }
    }
}