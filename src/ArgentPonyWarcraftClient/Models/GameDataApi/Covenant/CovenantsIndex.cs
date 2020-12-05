﻿using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// An index of covenants.
    /// </summary>
    public class CovenantsIndex
    {
        /// <summary>
        /// Gets the links for the index of covenants.
        /// </summary>
        [JsonPropertyName("_links")]
        public Links Links { get; set; }

        /// <summary>
        /// Gets the covenant references.
        /// </summary>
        [JsonPropertyName("covenants")]
        public CovenantReference[] Covenants { get; set; }
    }
}
