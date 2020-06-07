using System;
using System.Collections.Generic;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace Newtella_Winforms.Net.Models
{
    class Connection
    {
        [JsonProperty] public IPAddress LastKnownIP;
        [JsonProperty] public Guid NodeAdvertisedGUID;
        [JsonProperty] public string Description;
        [JsonProperty] public string NodeName;
        [JsonProperty] public bool IsBanned;
        [JsonProperty] public int Port;
        [JsonProperty] public PublicKey NodePublicKey;
    }
}
