﻿
using System.Text.Json.Serialization;

namespace Plex.Api.Models
{
    public class Director
    { 
        [JsonPropertyName("tag")]
        public string Tag { get; set; }
    }
}