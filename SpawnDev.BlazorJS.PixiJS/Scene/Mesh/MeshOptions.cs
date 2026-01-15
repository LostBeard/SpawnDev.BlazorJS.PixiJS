using Microsoft.JSInterop;

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
            /// Deserialization constructor
            /// </summary>
            public MeshOptions(IJSInProcessObjectReference _ref) : base(_ref) { }

            /// <summary>
            /// Creates a new instance
            /// </summary>
            public MeshOptions() : base(JS.New("Object")) { }

            /// <summary>
            /// The geometry the mesh will use.
            /// </summary>
            public JSObject? Geometry { get => JSRef!.Get<JSObject?>("geometry"); set => JSRef!.Set("geometry", value); }

            /// <summary>
            /// The shader the mesh will use.
            /// </summary>
            public JSObject? Shader { get => JSRef!.Get<JSObject?>("shader"); set => JSRef!.Set("shader", value); }

            /// <summary>
            /// The state that will be used to render the mesh.
            /// </summary>
            public JSObject? State { get => JSRef!.Get<JSObject?>("state"); set => JSRef!.Set("state", value); }

            /// <summary>
            /// The drawMode to be used when rendering the mesh.
            /// </summary>
            public int? DrawMode { get => JSRef!.Get<int?>("drawMode"); set => JSRef!.Set("drawMode", value); }

            /// <summary>
            /// Whether or not to round the x/y position of the object.
            /// </summary>
            public bool? RoundPixels { get => JSRef!.Get<bool?>("roundPixels"); set => JSRef!.Set("roundPixels", value); }
        }
    }
}
