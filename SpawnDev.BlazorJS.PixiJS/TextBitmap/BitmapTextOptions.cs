using System.Text.Json.Serialization;

namespace SpawnDev.BlazorJS.PixiJS
{
    public static partial class PIXI
    {
        /// <summary>
        /// Options for the BitmapText constructor.<br/>
        /// https://pixijs.download/release/docs/scene.BitmapTextOptions.html
        /// </summary>
        public class BitmapTextOptions : TextOptions
        {
            /// <summary>
            /// The resolution of the text.
            /// </summary>
            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
            [JsonPropertyName("resolution")]
            public float? Resolution { get; set; }
        }
    }
}
