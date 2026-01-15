using System.Text.Json.Serialization;

namespace SpawnDev.BlazorJS.PixiJS
{
    public static partial class PIXI
    {
        /// <summary>
        /// Options for the Mesh constructor.<br/>
        /// https://pixijs.download/release/docs/scene.MeshOptions.html
        /// </summary>
        public class MeshOptions : ContainerOptions
        {
            /// <summary>
            /// The geometry the mesh will use.
            /// </summary>
            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
            [JsonPropertyName("geometry")]
            public JSObject? Geometry { get; set; }

            /// <summary>
            /// The shader the mesh will use.
            /// </summary>
            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
            [JsonPropertyName("shader")]
            public JSObject? Shader { get; set; }

            /// <summary>
            /// The state that will be used to render the mesh.
            /// </summary>
            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
            [JsonPropertyName("state")]
            public JSObject? State { get; set; }

            /// <summary>
            /// The drawMode to be used when rendering the mesh.
            /// </summary>
            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
            [JsonPropertyName("drawMode")]
            public int? DrawMode { get; set; }

            /// <summary>
            /// Whether or not to round the x/y position of the object.
            /// </summary>
            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
            [JsonPropertyName("roundPixels")]
            public bool? RoundPixels { get; set; }
        }
    }
}
