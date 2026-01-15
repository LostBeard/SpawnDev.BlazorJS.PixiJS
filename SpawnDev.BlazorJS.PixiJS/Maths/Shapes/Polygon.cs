using Microsoft.JSInterop;

namespace SpawnDev.BlazorJS.PixiJS
{
    public static partial class PIXI
    {
        /// <summary>
        /// A class to define a shape via an appropriate array of coordinates.<br/>
        /// https://pixijs.download/v8.14.3/docs/maths.Polygon.html
        /// </summary>
        public class Polygon : JSObject
        {
            /// <summary>
            /// Deserialization constructor
            /// </summary>
            public Polygon(IJSInProcessObjectReference _ref) : base(_ref) { }

            /// <summary>
            /// Creates a new instance
            /// </summary>
            /// <param name="points">An array of Points that make up the polygon</param>
            public Polygon(Point[] points) : base(JS.New("PIXI.Polygon", (object)points)) { }

            /// <summary>
            /// Creates a new instance
            /// </summary>
            /// <param name="points">An array of numbers that make up the polygon</param>
            public Polygon(float[] points) : base(JS.New("PIXI.Polygon", (object)points)) { }

            /// <summary>
            /// An array of numbers that make up the polygon
            /// </summary>
            public float[] Points { get => JSRef!.Get<float[]>("points"); set => JSRef!.Set("points", value); }

            /// <summary>
            /// Whether to close the stroke
            /// </summary>
            public bool CloseStroke { get => JSRef!.Get<bool>("closeStroke"); set => JSRef!.Set("closeStroke", value); }
        }
    }
}
