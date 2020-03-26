﻿using Newtonsoft.Json;

namespace GitHubReadmeScanner
{
    abstract class GraphQLRequest
    {
        protected GraphQLRequest(string query, string variables = "") => (Query, Variables) = (query, variables);

        [JsonProperty("query")]
        public string Query { get; }

        [JsonProperty("variables")]
        public string Variables { get; }
    }
}
