using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.PixiJS
{
    public static partial class PIXI
    {
        /// <summary>
        /// Color source
        /// </summary>
        public class ColorSource : Union<string, float, float[], byte[], Uint8Array, Uint8ClampedArray>
        {
            public static implicit operator ColorSource(string instance) => instance == null ? null : new ColorSource(instance);
            public static implicit operator ColorSource(float instance) => instance == null ? null : new ColorSource(instance);
            public static implicit operator ColorSource(float[] instance) => instance == null ? null : new ColorSource(instance);
            public static implicit operator ColorSource(byte[] instance) => instance == null ? null : new ColorSource(instance);
            public static implicit operator string(ColorSource instance) => instance == null ? null : instance.Value as string;
            public static implicit operator float?(ColorSource instance) => instance == null || !(instance.Value is float) ? null : (float)instance.Value;
            public static implicit operator float[](ColorSource instance) => instance == null ? null : instance.Value as float[];
            public static implicit operator byte[](ColorSource instance) => instance == null ? null : instance.Value as byte[];

            /// <summary>
            /// Creates a new instance
            /// </summary>
            /// <param name="color"></param>
            public ColorSource(string color) : base(color) { }
            /// <summary>
            /// Creates a new instance
            /// </summary>
            /// <param name="color"></param>
            public ColorSource(float color) : base(color) { }
            /// <summary>
            /// Creates a new instance
            /// </summary>
            /// <param name="color"></param>
            public ColorSource(float[] color) : base(color) { }
            /// <summary>
            /// Creates a new instance
            /// </summary>
            /// <param name="color"></param>
            public ColorSource(byte[] color) : base(color) { }
        }
    }
}
