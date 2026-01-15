using Microsoft.JSInterop;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.PixiJS
{
    public static partial class PIXI
    {
        /// <summary>
        /// A MeshSimple is a Mesh with valid Geometery that can be easily modified.<br/>
        /// https://pixijs.download/v8.14.3/docs/scene.MeshSimple.html
        /// </summary>
        public class MeshSimple : Mesh
        {
            /// <summary>
            /// Deserialization constructor
            /// </summary>
            public MeshSimple(IJSInProcessObjectReference _ref) : base(_ref) { }
            
            /// <summary>
            /// Creates a new MeshSimple instance.
            /// </summary>
            /// <param name="texture">The texture to use</param>
            /// <param name="vertices">if you want to specify the vertices</param>
            /// <param name="uvs">if you want to specify the uvs</param>
            /// <param name="indices">if you want to specify the indices</param>
            /// <param name="drawMode">the drawMode to be used</param>
            public MeshSimple(Texture texture, float[]? vertices = null, float[]? uvs = null, ushort[]? indices = null, int? drawMode = null)
                : base(JS.New("PIXI.MeshSimple", texture, vertices, uvs, indices, drawMode)) { }
            
            /// <summary>
            /// Collection of vertices data.
            /// </summary>
            public Float32Array Vertices => JSRef!.Get<Float32Array>("vertices");
            
            /// <summary>
            /// Collection of uvs data.
            /// </summary>
            public Float32Array Uvs => JSRef!.Get<Float32Array>("uvs");
            
            /// <summary>
            /// Collection of indices data.
            /// </summary>
            public Uint16Array Indices => JSRef!.Get<Uint16Array>("indices");
            
            /// <summary>
            /// upload vertices buffer each frame
            /// </summary>
            public bool AutoUpdate { get => JSRef!.Get<bool>("autoUpdate"); set => JSRef!.Set("autoUpdate", value); }
        }
    }
}
