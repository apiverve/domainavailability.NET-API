using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace APIVerve
{
public class owner
{
    [JsonProperty("registrar")]
    public string registrar { get; set; }

}

public class data
{
    [JsonProperty("domain")]
    public string domain { get; set; }

    [JsonProperty("isAvailable")]
    public bool isAvailable { get; set; }

    [JsonProperty("owner")]
    public owner owner { get; set; }

}

public class ResponseObj
{
    [JsonProperty("status")]
    public string status { get; set; }

    [JsonProperty("error")]
    public object error { get; set; }

    [JsonProperty("data")]
    public data data { get; set; }

}

}
