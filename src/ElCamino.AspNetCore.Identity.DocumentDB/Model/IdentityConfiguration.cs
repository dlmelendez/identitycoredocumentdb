﻿// MIT License Copyright 2019 (c) David Melendez. All rights reserved. See License.txt in the project root for license information.

using ElCamino.AspNetCore.Identity.DocumentDB.Helpers;
using Microsoft.Azure.Documents.Client;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Security;

namespace ElCamino.AspNetCore.Identity.DocumentDB.Model
{
    [JsonObject("identityConfiguration", NamingStrategyType = typeof(CamelCaseNamingStrategy))]
    public class IdentityConfiguration
    {
        public string Uri { get; set; }

        public string AuthKey { get; set; }

        public string Database { get; set; }

        public string IdentityCollection { get; set; } = Constants.DocumentCollectionIds.DefaultIdentityCollection;


        [JsonIgnore]
        public ConnectionPolicy Policy { get; set; } = ConnectionPolicy.Default;

        public override string ToString()
        {
            return HashHelper.ConvertToHash(
                Uri ?? string.Empty + 
                AuthKey ?? string.Empty + 
                Database ?? string.Empty + 
                IdentityCollection ?? string.Empty); 
        }

    }
}
