using Microsoft.JSInterop;

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
            /// Deserialization constructor
            /// </summary>
            public MeshSimpleOptions(IJSInProcessObjectReference _ref) : base(_ref) { }

            /// <summary>
            /// Creates a new instance
            /// </summary>
            public MeshSimpleOptions() : base(JS.New("Object")) { }

            /// <summary>
            /// The texture to use on the mesh.
            /// </summary>
            public Texture? Texture { get => JSRef!.Get<Texture?>("texture"); set => JSRef!.Set("texture", value); }

            /// <summary>
            /// Collection of vertices data.
            /// </summary>
            public float[]? Vertices { get => JSRef!.Get<float[]?>("vertices"); set => JSRef!.Set("vertices", value); }

            /// <summary>
            /// Collection of uvs data.
            /// </summary>
            public float[]? Uvs { get => JSRef!.Get<float[]?>("uvs"); set => JSRef!.Set("uvs", value); }

            /// <summary>
            /// Collection of indices data.
            /// </summary>
            public ushort[]? Indices { get => JSRef!.Get<ushort[]?>("indices"); set => JSRef!.Set("indices", value); }

            /// <summary>
            /// The rendering topology.
            /// </summary>
            public string? Topology { get => JSRef!.Get<string?>("topology"); set => JSRef!.Set("topology", value); }
        }
    }
}
