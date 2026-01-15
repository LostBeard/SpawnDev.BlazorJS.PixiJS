using Microsoft.JSInterop;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.PixiJS
{
    public static partial class PIXI
    {
        /// <summary>
        /// A wrapper for the PIXI.Geometry class.<br/>
        /// https://pixijs.download/v8.14.3/docs/rendering.Geometry.html
        /// </summary>
        public class Geometry : JSObject
        {
            /// <summary>
            /// Deserialization constructor
            /// </summary>
            public Geometry(IJSInProcessObjectReference _ref) : base(_ref) { }
            
            /// <summary>
            /// Creates a new Geometry instance.
            /// </summary>
            public Geometry() : base(JS.New("PIXI.Geometry")) { }

            /// <summary>
            /// Adds an attribute to the geometry.
            /// </summary>
            /// <param name="id">The name of the attribute (matching the shader).</param>
            /// <param name="buffer">The buffer containing the data.</param>
            /// <param name="size">The size of the attribute (e.g., 2 for vec2).</param>
            /// <param name="normalized">Whether the data should be normalized.</param>
            /// <param name="type">The type of the data.</param>
            /// <param name="stride">The stride of the data.</param>
            /// <param name="start">The start offset of the data.</param>
            /// <returns>This geometry instance.</returns>
            public Geometry AddAttribute(string id, Buffer buffer, int size = 0, bool normalized = false, int type = 0, int stride = 0, int start = 0)
            {
                JSRef!.CallVoid("addAttribute", id, buffer, size, normalized, type, stride, start);
                return this;
            }
            
            /// <summary>
            /// Adds an index buffer to the geometry.
            /// </summary>
            /// <param name="buffer">The index buffer.</param>
            /// <returns>This geometry instance.</returns>
            public Geometry AddIndex(Buffer buffer)
            {
                JSRef!.CallVoid("addIndex", buffer);
                return this;
            }

            /// <summary>
            /// Adds an index buffer to the geometry from an array.
            /// </summary>
            /// <param name="buffer">The index data.</param>
            /// <returns>This geometry instance.</returns>
            public Geometry AddIndex(uint[] buffer)
            {
                JSRef!.CallVoid("addIndex", new Uint32Array(buffer)); // Pixi accepts array or typed array, usually converts to Buffer internaly
                return this;
            }
             /// <summary>
            /// Adds an index buffer to the geometry from an array.
            /// </summary>
            /// <param name="buffer">The index data.</param>
            /// <returns>This geometry instance.</returns>
            public Geometry AddIndex(int[] buffer)
            {
                 JSRef!.CallVoid("addIndex", new Int32Array(buffer));
                 return this;
            }
        }
    }
}
