using Microsoft.JSInterop;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.PixiJS
{
    public static partial class PIXI
    {
        /// <summary>
        /// A wrapper for the PIXI.Buffer class.<br/>
        /// https://pixijs.download/v8.14.3/docs/rendering.Buffer.html
        /// </summary>
        public class Buffer : JSObject
        {
            /// <summary>
            /// Deserialization constructor
            /// </summary>
            public Buffer(IJSInProcessObjectReference _ref) : base(_ref) { }

            /// <summary>
            /// Creates a new Buffer instance.
            /// </summary>
            /// <param name="data">The data to store in the buffer.</param>
            public Buffer(TypedArray data) : base(JS.New("PIXI.Buffer", data)) { }

            /// <summary>
            /// Creates a new Buffer instance from a float array.
            /// </summary>
            /// <param name="data">The data to store in the buffer.</param>
            public Buffer(float[] data) : base(JS.New("PIXI.Buffer", new Float32Array(data))) { }
            /// <summary>
            /// Creates a new Buffer instance from an int array.
            /// </summary>
            /// <param name="data">The data to store in the buffer.</param>
            public Buffer(int[] data) : base(JS.New("PIXI.Buffer", new Int32Array(data))) { }

            /// <summary>
            /// Creates a new Buffer instance from a uint array.
            /// </summary>
            /// <param name="data">The data to store in the buffer.</param>
            public Buffer(uint[] data) : base(JS.New("PIXI.Buffer", new Uint32Array(data))) { }

            /// <summary>
            /// The data in the buffer.
            /// </summary>
            public TypedArray Data => JSRef!.Get<TypedArray>("data");
        }
    }
}
