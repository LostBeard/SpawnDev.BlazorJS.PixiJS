using Microsoft.JSInterop;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.PixiJS
{
    public static partial class PIXI
    {
        /// <summary>
        /// A fast matrix for 2D transformations.<br/>
        /// https://pixijs.download/v8.7.1/docs/maths.Matrix.html
        /// </summary>
        public class Matrix : JSObject
        {
            ///<inheritdoc/>
            public Matrix(IJSInProcessObjectReference _ref) : base(_ref) { }
            /// <summary>
            /// Create new instance
            /// </summary>
            /// <param name="a">x scale</param>
            /// <param name="b">y skew</param>
            /// <param name="c">x skew</param>
            /// <param name="d">y scale</param>
            /// <param name="tx">x translation</param>
            /// <param name="ty">y translation</param>
            public Matrix(float a = 1, float b = 0, float c = 0, float d = 1, float tx = 0, float ty = 0) : base(JS.New("PIXI.Matrix", a, b, c, d, tx, ty)) { }
            /// <summary>
            /// A default (identity) matrix.<br/>
            /// This is a shared object, if you want to modify it consider creating a new Matrix
            /// </summary>
            public static Matrix IDENTITY => JS.Get<Matrix>("PIXI.Matrix.IDENTITY");
            public float A { get => JSRef!.Get<float>("a"); set => JSRef!.Set("a", value); }
            public float B { get => JSRef!.Get<float>("b"); set => JSRef!.Set("b", value); }
            public float C { get => JSRef!.Get<float>("c"); set => JSRef!.Set("c", value); }
            public float D { get => JSRef!.Get<float>("d"); set => JSRef!.Set("d", value); }
            public float TX { get => JSRef!.Get<float>("tx"); set => JSRef!.Set("tx", value); }
            public float TY { get => JSRef!.Get<float>("ty"); set => JSRef!.Set("ty", value); }
            /// <summary>
            /// An array of the current matrix. Only populated when toArray is called
            /// </summary>
            public Float32Array? Array => JSRef!.Get<Float32Array?>("array");
        }
    }
}
