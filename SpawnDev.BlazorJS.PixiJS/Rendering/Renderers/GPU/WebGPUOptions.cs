using System.Text.Json.Serialization;

namespace SpawnDev.BlazorJS.PixiJS
{
    public static partial class PIXI
    {
        /// <summary>
        /// Options for WebGPURenderer.<br/>
        /// https://pixijs.download/release/docs/rendering.WebGPUOptions.html
        /// </summary>
        public class WebGPUOptions : SharedRendererOptions
        {
            /// <summary>
            /// Force the use of the fallback adapter
            /// </summary>
            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
            public bool? ForceFallbackAdapter { get; set; }
            /// <summary>
            /// An optional hint indicating what configuration of GPU is suitable for the WebGPU context, can be:<br/>
            /// 'high-performance' - will prioritize rendering performance over power consumption<br/>
            /// 'low-power' - will prioritize power saving over rendering performance<br/>
            /// </summary>
            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
            public EnumString<GpuPowerPreference>? PowerPreference { get; set; }
        }
    }
}
