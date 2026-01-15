using SpawnDev.BlazorJS.JSObjects;
using Microsoft.JSInterop;

namespace SpawnDev.BlazorJS.PixiJS
{
    public static partial class PIXI
    {
        /// <summary>
        /// Options for the MeshPlane constructor.
        /// </summary>
        public class MeshPlaneOptions : JSObject
        {
            /// <summary>
            /// Deserialization constructor
            /// </summary>
            public MeshPlaneOptions(IJSInProcessObjectReference _ref) : base(_ref) { }
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public MeshPlaneOptions() : base(JS.New("Object")) { }

            /// <summary>
            /// The texture to use.
            /// </summary>
            public Texture Texture { get => JSRef!.Get<Texture>("texture"); set => JSRef!.Set("texture", value); }
            public int? VerticesX { get => JSRef!.Get<int?>("verticesX"); set => JSRef!.Set("verticesX", value); }
            public int? VerticesY { get => JSRef!.Get<int?>("verticesY"); set => JSRef!.Set("verticesY", value); }
        }
    }
}
