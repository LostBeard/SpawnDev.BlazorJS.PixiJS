using Microsoft.JSInterop;

namespace SpawnDev.BlazorJS.PixiJS
{
    public static partial class PIXI
    {
        /// <summary>
        /// The Ellipse object is using to represent an ellipse with a position (x, y), half width and half height.<br/>
        /// https://pixijs.download/v8.14.3/docs/maths.Ellipse.html
        /// </summary>
        public class Ellipse : JSObject
        {
            /// <summary>
            /// Deserialization constructor
            /// </summary>
            public Ellipse(IJSInProcessObjectReference _ref) : base(_ref) { }

            /// <summary>
            /// Creates a new instance
            /// </summary>
            /// <param name="x">The X coordinate of the center of this ellipse</param>
            /// <param name="y">The Y coordinate of the center of this ellipse</param>
            /// <param name="halfWidth">The half width of this ellipse</param>
            /// <param name="halfHeight">The half height of this ellipse</param>
            public Ellipse(float x = 0, float y = 0, float halfWidth = 0, float halfHeight = 0) : base(JS.New("PIXI.Ellipse", x, y, halfWidth, halfHeight)) { }

            /// <summary>
            /// The X coordinate of the center of this ellipse
            /// </summary>
            public float X { get => JSRef!.Get<float>("x"); set => JSRef!.Set("x", value); }

            /// <summary>
            /// The Y coordinate of the center of this ellipse
            /// </summary>
            public float Y { get => JSRef!.Get<float>("y"); set => JSRef!.Set("y", value); }

            /// <summary>
            /// The half width of this ellipse
            /// </summary>
            public float HalfWidth { get => JSRef!.Get<float>("halfWidth"); set => JSRef!.Set("halfWidth", value); }

            /// <summary>
            /// The half height of this ellipse
            /// </summary>
            public float HalfHeight { get => JSRef!.Get<float>("halfHeight"); set => JSRef!.Set("halfHeight", value); }
        }
    }
}
