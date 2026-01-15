using System.Text.Json.Serialization;

namespace SpawnDev.BlazorJS.PixiJS
{
    public static partial class PIXI
    {
        /// <summary>
        /// Options for the MeshRope constructor.<br/>
        /// https://pixijs.download/release/docs/scene.MeshRopeOptions.html
        /// </summary>
        public class MeshRopeOptions : MeshSimpleOptions
        {
            /// <summary>
            /// An array of {PIXI.Point} objects to construct this rope.
            /// </summary>
            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
            [JsonPropertyName("points")]
            public Point[]? Points { get; set; }

            /// <summary>
            /// Optional. Positive values scale rope texture keeping its aspect ratio. You can reduce alpha channel artifacts by providing a larger texture and downscaling here. If set to zero, texture will be stretched instead.
            /// </summary>
            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
            [JsonPropertyName("textureScale")]
            public float? TextureScale { get; set; }
        }
    }
}
