using System.Text.Json.Serialization;

namespace SpawnDev.BlazorJS.PixiJS
{
    public static partial class PIXI
    {
        /// <summary>
        /// Options for the TilingSprite constructor.<br/>
        /// https://pixijs.download/release/docs/scene.TilingSpriteOptions.html
        /// </summary>
        public class TilingSpriteOptions : SpriteOptions
        {
            /// <summary>
            /// The width of the tiling sprite.
            /// </summary>
            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
            [JsonPropertyName("width")]
            public float? Width { get; set; }

            /// <summary>
            /// The height of the tiling sprite.
            /// </summary>
            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
            [JsonPropertyName("height")]
            public float? Height { get; set; }
        }
    }
}
