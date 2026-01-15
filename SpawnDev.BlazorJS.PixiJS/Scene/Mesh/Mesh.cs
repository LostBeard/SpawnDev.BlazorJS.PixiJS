using Microsoft.JSInterop;

namespace SpawnDev.BlazorJS.PixiJS
{
    public static partial class PIXI
    {
        /// <summary>
        /// Base mesh class.<br/>
        /// https://pixijs.download/v8.14.3/docs/scene.Mesh.html
        /// </summary>
        public class Mesh : Container
        {
            /// <summary>
            /// Deserialization constructor
            /// </summary>
            public Mesh(IJSInProcessObjectReference _ref) : base(_ref) { }
            // Using JSObject for Geometry and Shader for now as they are not fully wrapped yet

            /// <summary>
            /// Creates a new Mesh instance.
            /// </summary>
            /// <param name="options">The options to use.</param>
            public Mesh(MeshOptions options) : base(JS.New("PIXI.Mesh", options)) { }

            /// <summary>
            /// Creates a new Mesh instance.
            /// </summary>
            /// <param name="geometry">The geometry the mesh will use.</param>
            /// <param name="shader">The shader the mesh will use.</param>
            /// <param name="state">The state that will be used to render the mesh.</param>
            /// <param name="drawMode">The drawMode to be used when rendering the mesh.</param>
            public Mesh(JSObject geometry, JSObject shader, JSObject? state = null, int? drawMode = null)
                : this(CreateMeshOptions(geometry, shader, state, drawMode)) { }

            static MeshOptions CreateMeshOptions(JSObject geometry, JSObject shader, JSObject? state = null, int? drawMode = null)
            {
                var options = new MeshOptions();
                options.Geometry = geometry;
                options.Shader = shader;
                options.State = state;
                options.DrawMode = drawMode;
                return options;
            }

            /// <summary>
            /// Includes vertex positions, face indices, normals, colors, UVs and custom attributes within buffers.
            /// </summary>
            public JSObject Geometry => JSRef!.Get<JSObject>("geometry");
            public JSObject Shader => JSRef!.Get<JSObject>("shader");
            public Texture Texture { get => JSRef!.Get<Texture>("texture"); set => JSRef!.Set("texture", value); }
            public int CurrentDrawMode => JSRef!.Get<int>("drawMode");
        }
    }
}
