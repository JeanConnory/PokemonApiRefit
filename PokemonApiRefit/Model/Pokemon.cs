﻿using Newtonsoft.Json;

namespace PokemonApiRefit.Model
{
    public class Pokemon
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("height")]
        public long Height { get; set; }

        [JsonProperty("base_experience")]
        public long Base_experience { get; set; }

        [JsonProperty("weight")]
        public long Weight { get; set; }

        public string? Image { get; set; }
    }
}
