using System.Text.Json.Serialization;

namespace SpawnDev.BlazorJS.PixiJS
{
    public static partial class PIXI
    {
        /// <summary>
        /// Options for the MeshPlane constructor.<br/>
        /// https://pixijs.download/release/docs/scene.MeshPlaneOptions.html
        /// </summary>
        public class MeshPlaneOptions : MeshSimpleOptions
        {
            /// <summary>
            /// The number of vertices on the x-axis.
            /// </summary>
            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
            [JsonPropertyName("verticesX")]
            public int? VerticesX { get; set; }

            /// <summary>
            /// The number of vertices on the y-axis.
            /// </summary>
            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
            [JsonPropertyName("verticesY")]
            public int? VerticesY { get; set; }
        }
    }
}
