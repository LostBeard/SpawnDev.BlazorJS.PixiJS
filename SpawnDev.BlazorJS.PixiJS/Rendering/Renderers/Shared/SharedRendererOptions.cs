using System.Text.Json.Serialization;

namespace SpawnDev.BlazorJS.PixiJS
{
    public static partial class PIXI
    {
        // https://pixijs.download/release/docs/rendering.SharedRendererOptions.html
        public class SharedRendererOptions
        {

            /// <summary>
            /// Whether to enable anti-aliasing. This may affect performance.
            /// </summary>
            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
            public bool? Antialias { get; set; }
            /// <summary>
            /// Resizes renderer view in CSS pixels to allow for resolutions other than 1.
            /// </summary>
            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
            public bool? AutoDensity { get; set; }
            /// <summary>
            /// Alias for backgroundColor
            /// </summary>
            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
            public string? Background { get; set; }
        }
    }
}
