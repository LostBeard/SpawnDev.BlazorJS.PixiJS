using System.Text.Json.Serialization;

namespace SpawnDev.BlazorJS.PixiJS
{
    public static partial class PIXI
    {
        /// <summary>
        /// Options for the Sprite constructor.<br/>
        /// https://pixijs.download/release/docs/scene.SpriteOptions.html
        /// </summary>
        public class SpriteOptions : ContainerOptions
        {
            /// <summary>
            /// The texture to use.
            /// </summary>
            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
            [JsonPropertyName("texture")]
            public Texture? Texture { get; set; }
        }
    }
}
