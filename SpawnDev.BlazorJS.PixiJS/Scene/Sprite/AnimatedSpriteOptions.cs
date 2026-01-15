using System.Text.Json.Serialization;

namespace SpawnDev.BlazorJS.PixiJS
{
    public static partial class PIXI
    {
        /// <summary>
        /// Options for the AnimatedSprite constructor.<br/>
        /// https://pixijs.download/release/docs/scene.AnimatedSpriteOptions.html
        /// </summary>
        public class AnimatedSpriteOptions : SpriteOptions
        {
            /// <summary>
            /// An array of Texture objects that make up the animation.
            /// </summary>
            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
            [JsonPropertyName("textures")]
            public Texture[]? Textures { get; set; }

            /// <summary>
            /// Whether to use PIXI.Ticker.shared to auto update animation time.
            /// </summary>
            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
            [JsonPropertyName("autoUpdate")]
            public bool? AutoUpdate { get; set; }
        }
    }
}
