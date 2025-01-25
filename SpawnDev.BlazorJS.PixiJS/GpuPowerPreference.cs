using SpawnDev.BlazorJS.JsonConverters;
using System.Text.Json.Serialization;

namespace SpawnDev.BlazorJS.PixiJS
{
    public static partial class PIXI
    {
        /// <summary>
        /// Used in WebGPUOptions
        /// </summary>
        [JsonConverter(typeof(EnumStringConverterFactory))]
        public enum GpuPowerPreference
        {
            /// <summary>
            /// Will prioritize rendering performance over power consumption
            /// </summary>
            [JsonPropertyName("high-performance")]
            HighPerformance,
            /// <summary>
            /// Will prioritize power saving over rendering performance
            /// </summary>
            [JsonPropertyName("low-power")]
            LowPower,
        }
    }
}
