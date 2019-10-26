
using Disboard.Models;

using Newtonsoft.Json;

namespace Disboard.Misskey.Models
{
    public class InvitationCode : ApiResponse
    {
        [JsonProperty("code")]
        public string Code { get; set; }
    }
}