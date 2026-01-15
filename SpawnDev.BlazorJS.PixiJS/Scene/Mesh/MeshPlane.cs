using Microsoft.JSInterop;

namespace SpawnDev.BlazorJS.PixiJS
{
    public static partial class PIXI
    {
        /// <summary>
        /// The MeshPlane allows you to draw a texture across several points and then manipulate these points.<br/>
        /// https://pixijs.download/v8.14.3/docs/scene.MeshPlane.html
        /// </summary>
        public class MeshPlane : MeshSimple
        {
            /// <summary>
            /// Deserialization constructor
            /// </summary>
            public MeshPlane(IJSInProcessObjectReference _ref) : base(_ref) { }

            /// <summary>
            /// Creates a new MeshPlane instance.
            /// </summary>
            public MeshPlane(MeshPlaneOptions options) : base(JS.New("PIXI.MeshPlane", options)) { }

            /// <summary>
            /// Creates a new MeshPlane instance.
            /// </summary>
            /// <param name="texture">The texture to use.</param>
            /// <param name="verticesX">The number of vertices in the x-axis.</param>
            /// <param name="verticesY">The number of vertices in the y-axis.</param>
            public MeshPlane(Texture texture, int verticesX = 10, int verticesY = 10)
                : this(new MeshPlaneOptions { Texture = texture, VerticesX = verticesX, VerticesY = verticesY }) { }

            /// <summary>
            /// The number of vertices on the x-axis.
            /// </summary>
            public int VerticesX => JSRef!.Get<int>("verticesX");
            /// <summary>
            /// The number of vertices on the y-axis.
            /// </summary>
            public int VerticesY => JSRef!.Get<int>("verticesY");
        }
    }
}
