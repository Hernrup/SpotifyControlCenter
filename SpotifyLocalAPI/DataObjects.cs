﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpotifyLocalApi
{
    public class Status {
        public error error { get; set; }
        public int version { get; set; }
        public string client_version { get; set; }
        public bool playing { get; set; }
        public bool shuffle { get; set; }
        public bool repeat { get; set; }

        [JsonProperty("play_enabled")]
        public bool playEnabled { get; set; }

        [JsonProperty("prev_enabled")]
        public bool prevEnabled { get; set; }

        public track track { get; set; }

        [JsonProperty("playing_position")]
        public double playingPosition { get; set; }
        public int server_time { get; set; }
        public double volume { get; set; }
        public bool online { get; set; }
        public open_graph_state open_graph_state { get; set; }
        public bool running { get; set; }
    }

    public class ClientVersion {
        public error error { get; set; }
        public int version { get; set; }
        public string client_version { get; set; }
        public bool running { get; set; }
    }

    public class CFID {
        public error error { get; set; }
        public string token { get; set; }
    }

    public class track {
        [JsonProperty("track_resource")]
        public resource trackResource { get; set; }

        [JsonProperty("artist_resource")]
        public resource artistResource { get; set; }

        [JsonProperty("album_resource")]
        public resource albumResource { get; set; }

        [JsonProperty("length")]
        public int length { get; set; }

        [JsonProperty("track_type")]
        public string trackType { get; set; }
    }


    public class error {
        public string type { get; set; }
        public string message { get; set; }
    }


    public class open_graph_state {
        public bool private_session { get; set; }
        public bool posting_disabled { get; set; }
    }

    public class resource {
        public string name { get; set; }
        public string uri { get; set; }
        public location location { get; set; }
    }

    public class location {
        public string og { get; set; }
    }

}
