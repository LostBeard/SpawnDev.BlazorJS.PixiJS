using System.Text.Json.Serialization;

namespace SpawnDev.BlazorJS.PixiJS
{
    public static partial class PIXI
    {
        /// <summary>
        /// Options for the HTMLText constructor.<br/>
        /// https://pixijs.download/release/docs/scene.HTMLTextOptions.html
        /// </summary>
        public class HTMLTextOptions : SpriteOptions
        {
            /// <summary>
            /// The text to render.
            /// </summary>
            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
            [JsonPropertyName("text")]
            public string? Text { get; set; }

            /// <summary>
            /// The style to use.
            /// </summary>
            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
            [JsonPropertyName("style")]
            public Union<HTMLTextStyle, HTMLTextStyleOptions>? Style { get; set; }
        }
    }
}
