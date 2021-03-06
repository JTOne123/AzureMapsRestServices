﻿using Newtonsoft.Json;

namespace AzureMapsToolkit.Search
{
    public class SearchResult
    {
        /// <summary>
        /// The address of the result
        /// </summary>
        [JsonProperty("address")]
        public SearchResultAddress Address { get; set; }

        
        /// <summary>
        /// Entry Points array
        /// </summary>
        [JsonProperty("entryPoints")]
        public SearchResultEntryPoint[] EntryPoints { get; set; }

        /// <summary>
        /// Id property
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

       

        /// <summary>
        /// Details of the poi including the name, phone, url, and categories.
        /// </summary>
        [JsonProperty("poi")]
        public SearchResultPoi Poi { get; set; }

        /// <summary>
        /// A location represented as a latitude and longitude.
        /// </summary>
        [JsonProperty("position")]
        public CoordinateAbbreviated Position { get; set; }


        /// <summary>
        /// The value within a result set to indicate the relative matching score between results. You can use this to determine that result x is twice as likely to be as relevant as result y if the value of x is 2x the value of y. The values vary between queries and is only meant as a relative value for one result set.
        /// </summary>
        [JsonProperty("score")]
        public double Score { get; set; }

        /// <summary>
        /// Type property
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }


        /// <summary>
        /// The viewport that covers the result represented by the top-left and bottom-right coordinates of the viewport.
        /// </summary>
        [JsonProperty("viewport")]
        public SearchResultViewport Viewport { get; set; }
    }
}