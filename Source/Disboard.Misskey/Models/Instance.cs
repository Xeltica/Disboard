﻿using System;

using Disboard.Models;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Disboard.Misskey.Models
{
    public class Instance : ApiResponse
    {
        [JsonProperty("_id")]
        public string Id { get; set; }

        [JsonProperty("host")]
        public string Host { get; set; }

        [JsonProperty("caughtAt")]
        [JsonConverter(typeof(IsoDateTimeConverter))]
        public DateTime CaughtAt { get; set; }

        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("usersCount")]
        public long UsersCount { get; set; }

        [JsonProperty("notesCount")]
        public long NotesCount { get; set; }

        [JsonProperty("followingCount")]
        public long FollowingCount { get; set; }

        [JsonProperty("followersCount")]
        public long FollowersCount { get; set; }

        [JsonProperty("driveUsage")]
        public long DriveUsage { get; set; }

        [JsonProperty("driveFiles")]
        public long DriveFiles { get; set; }

        [JsonProperty("latestRequestSentAt")]
        [JsonConverter(typeof(IsoDateTimeConverter))]
        public DateTime? LatestRequestSentAt { get; set; }

        [JsonProperty("latestStatus")]
        public int? LatestStatus { get; set; }

        [JsonProperty("latestRequestReceivedAt")]
        [JsonConverter(typeof(IsoDateTimeConverter))]
        public DateTime? LatestRequestReceivedAt { get; set; }

        [JsonProperty("isNotResponding")]
        public bool IsNotResponding { get; set; }

        [JsonProperty("lastCommunicatedAt")]
        [JsonConverter(typeof(IsoDateTimeConverter))]
        public DateTime LastCommunicatedAt { get; set; }

		[JsonProperty("disableGlobalTimeline")]
		public bool DisableGlobalTimeline { get; set; }

		[JsonProperty("enableEmojiReaction")]
		public bool EnableEmojiReaction { get; set; }

		[JsonProperty("driveCapacityPerLocalUserMb")]
        public long DriveCapacityPerLocalUserMb { get; set; }

        [JsonProperty("isBlocked")]
        public bool IsBlocked { get; set; }

        [JsonProperty("isMarkedAsClosed")]
        public bool IsMarkedAtClosed { get; set; }
    }
}
