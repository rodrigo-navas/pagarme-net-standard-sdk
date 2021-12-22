// <copyright file="GetAutomaticAnticipationResponse.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace PagarmeApiSDK.Standard.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using JsonSubTypes;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using PagarmeApiSDK.Standard;
    using PagarmeApiSDK.Standard.Utilities;

    /// <summary>
    /// GetAutomaticAnticipationResponse.
    /// </summary>
    public class GetAutomaticAnticipationResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetAutomaticAnticipationResponse"/> class.
        /// </summary>
        public GetAutomaticAnticipationResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAutomaticAnticipationResponse"/> class.
        /// </summary>
        /// <param name="enabled">enabled.</param>
        /// <param name="type">type.</param>
        /// <param name="volumePercentage">volume_percentage.</param>
        /// <param name="delay">delay.</param>
        /// <param name="days">days.</param>
        public GetAutomaticAnticipationResponse(
            bool enabled,
            string type,
            int volumePercentage,
            int delay,
            List<int> days)
        {
            this.Enabled = enabled;
            this.Type = type;
            this.VolumePercentage = volumePercentage;
            this.Delay = delay;
            this.Days = days;
        }

        /// <summary>
        /// Gets or sets Enabled.
        /// </summary>
        [JsonProperty("enabled")]
        public bool Enabled { get; set; }

        /// <summary>
        /// Gets or sets Type.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets VolumePercentage.
        /// </summary>
        [JsonProperty("volume_percentage")]
        public int VolumePercentage { get; set; }

        /// <summary>
        /// Gets or sets Delay.
        /// </summary>
        [JsonProperty("delay")]
        public int Delay { get; set; }

        /// <summary>
        /// Gets or sets Days.
        /// </summary>
        [JsonProperty("days")]
        public List<int> Days { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"GetAutomaticAnticipationResponse : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            if (obj == this)
            {
                return true;
            }

            return obj is GetAutomaticAnticipationResponse other &&
                this.Enabled.Equals(other.Enabled) &&
                ((this.Type == null && other.Type == null) || (this.Type?.Equals(other.Type) == true)) &&
                this.VolumePercentage.Equals(other.VolumePercentage) &&
                this.Delay.Equals(other.Delay) &&
                ((this.Days == null && other.Days == null) || (this.Days?.Equals(other.Days) == true));
        }
        

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Enabled = {this.Enabled}");
            toStringOutput.Add($"this.Type = {(this.Type == null ? "null" : this.Type == string.Empty ? "" : this.Type)}");
            toStringOutput.Add($"this.VolumePercentage = {this.VolumePercentage}");
            toStringOutput.Add($"this.Delay = {this.Delay}");
            toStringOutput.Add($"this.Days = {(this.Days == null ? "null" : $"[{string.Join(", ", this.Days)} ]")}");
        }
    }
}