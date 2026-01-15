using System.Text.Json.Serialization;

namespace SpawnDev.BlazorJS.PixiJS
{
    public static partial class PIXI
    {
        /// <summary>
        /// Options for the Graphics constructor.<br/>
        /// https://pixijs.download/release/docs/scene.GraphicsOptions.html
        /// </summary>
        public class GraphicsOptions : ContainerOptions
        {
            /// <summary>
            /// The graphics context to use.
            /// </summary>
            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
            [JsonPropertyName("context")]
            public JSObject? Context { get; set; }

            /// <summary>
            /// Whether or not to round the x/y position of the object.
            /// </summary>
            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
            [JsonPropertyName("roundPixels")]
            public bool? RoundPixels { get; set; }
        }
    }
}
