using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace APIVerve
{
    /// <summary>
    /// Owner data
    /// </summary>
    public class Owner
    {
        [JsonProperty("registrar")]
        public string Registrar { get; set; }

    }
    /// <summary>
    /// Data data
    /// </summary>
    public class Data
    {
        [JsonProperty("domain")]
        public string Domain { get; set; }

        [JsonProperty("available")]
        public bool Available { get; set; }

        [JsonProperty("owner")]
        public Owner Owner { get; set; }

    }
    /// <summary>
    /// API Response object
    /// </summary>
    public class ResponseObj
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("error")]
        public object Error { get; set; }

        [JsonProperty("data")]
        public Data Data { get; set; }

    }
}
