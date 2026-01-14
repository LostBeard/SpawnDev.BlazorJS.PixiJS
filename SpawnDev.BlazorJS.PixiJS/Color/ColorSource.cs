using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.PixiJS
{
    public static partial class PIXI
    {
        /// <summary>
        /// Color source
        /// </summary>
        public class ColorSource : Union<string, float, float[], byte[], Uint8Array, Uint8ClampedArray, int>
        {
            /// <summary>
            /// Conversion operators for each type in the union.<br/>
            /// If the Union contains a value of the specified type, returns that value, otherwise returns the default value of the specified type.
            /// </summary>
            public static explicit operator string(ColorSource instance) => instance._type == 1 ? (string)instance.Value! : default(string)!;
            /// <summary>
            /// Conversion operators for each type in the union.<br/>
            /// If the Union contains a value of the specified type, returns that value, otherwise returns the default value of the specified type.
            /// </summary>
            public static explicit operator float(ColorSource instance) => instance._type == 2 ? (float)instance.Value! : default(float)!;
            /// <summary>
            /// Conversion operators for each type in the union.<br/>
            /// If the Union contains a value of the specified type, returns that value, otherwise returns the default value of the specified type.
            /// </summary>
            public static explicit operator float[](ColorSource instance) => instance._type == 3 ? (float[])instance.Value! : default(float[])!;
            /// <summary>
            /// Conversion operators for each type in the union.<br/>
            /// If the Union contains a value of the specified type, returns that value, otherwise returns the default value of the specified type.
            /// </summary>
            public static explicit operator byte[](ColorSource instance) => instance._type == 4 ? (byte[])instance.Value! : default(byte[])!;
            /// <summary>
            /// Conversion operators for each type in the union.<br/>
            /// If the Union contains a value of the specified type, returns that value, otherwise returns the default value of the specified type.
            /// </summary>
            public static explicit operator Uint8Array(ColorSource instance) => instance._type == 5 ? (Uint8Array)instance.Value! : default(Uint8Array)!;
            /// <summary>
            /// Conversion operators for each type in the union.<br/>
            /// If the Union contains a value of the specified type, returns that value, otherwise returns the default value of the specified type.
            /// </summary>
            public static explicit operator Uint8ClampedArray(ColorSource instance) => instance._type == 6 ? (Uint8ClampedArray)instance.Value! : default(Uint8ClampedArray)!;
            /// <summary>
            /// Conversion operators for each type in the union.<br/>
            /// If the Union contains a value of the specified type, returns that value, otherwise returns the default value of the specified type.
            /// </summary>
            public static explicit operator int(ColorSource instance) => instance._type == 7 ? (int)instance.Value! : default(int)!;
            /// <summary>
            /// Conversion operators for each type in the union
            /// </summary>
            public static implicit operator ColorSource(string instance) => instance == null ? null! : new ColorSource(instance);
            /// <summary>
            /// Conversion operators for each type in the union
            /// </summary>
            public static implicit operator ColorSource(float instance) => new ColorSource(instance);
            /// <summary>
            /// Conversion operators for each type in the union
            /// </summary>
            public static implicit operator ColorSource(float[] instance) => instance == null ? null! : new ColorSource(instance);
            /// <summary>
            /// Conversion operators for each type in the union
            /// </summary>
            public static implicit operator ColorSource(byte[] instance) => instance == null ? null! : new ColorSource(instance);
            /// <summary>
            /// Conversion operators for each type in the union
            /// </summary>
            public static implicit operator ColorSource(Uint8Array instance) => instance == null ? null! : new ColorSource(instance);
            /// <summary>
            /// Conversion operators for each type in the union
            /// </summary>
            public static implicit operator ColorSource(Uint8ClampedArray instance) => instance == null ? null! : new ColorSource(instance);
            /// <summary>
            /// Conversion operators for each type in the union
            /// </summary>
            public static implicit operator ColorSource(int instance) => new ColorSource(instance);
            /// <summary>
            /// Creates a new instance
            /// </summary>
            /// <param name="color"></param>
            public ColorSource(string color) : base(color) { }
            /// <summary>
            /// Creates a new instance
            /// </summary>
            /// <param name="color"></param>
            public ColorSource(int color) : base(color) { }
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
            /// <summary>
            /// Creates a new instance
            /// </summary>
            /// <param name="color"></param>
            public ColorSource(Uint8Array color) : base(color) { }
            /// <summary>
            /// Creates a new instance
            /// </summary>
            /// <param name="color"></param>
            public ColorSource(Uint8ClampedArray color) : base(color) { }
        }
    }
}
