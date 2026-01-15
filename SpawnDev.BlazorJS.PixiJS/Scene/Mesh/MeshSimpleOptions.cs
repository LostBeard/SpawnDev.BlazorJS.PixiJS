using System.Text.Json.Serialization;

namespace SpawnDev.BlazorJS.PixiJS
{
    public static partial class PIXI
    {
        /// <summary>
        /// Options for the MeshSimple constructor.<br/>
        /// https://pixijs.download/release/docs/scene.SimpleMeshOptions.html
        /// </summary>
        public class MeshSimpleOptions : MeshOptions
        {
            /// <summary>
            /// The texture to use on the mesh.
            /// </summary>
            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
            [JsonPropertyName("texture")]
            public Texture? Texture { get; set; }

            /// <summary>
            /// Collection of vertices data.
            /// </summary>
            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
            [JsonPropertyName("vertices")]
            public float[]? Vertices { get; set; }

            /// <summary>
            /// Collection of uvs data.
            /// </summary>
            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
            [JsonPropertyName("uvs")]
            public float[]? Uvs { get; set; }

            /// <summary>
            /// Collection of indices data.
            /// </summary>
            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
            [JsonPropertyName("indices")]
            public ushort[]? Indices { get; set; }

            /// <summary>
            /// The rendering topology.
            /// </summary>
            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
            [JsonPropertyName("topology")]
            public string? Topology { get; set; }
        }
    }
}
