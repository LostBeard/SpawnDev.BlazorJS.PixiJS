using Microsoft.JSInterop;

namespace SpawnDev.BlazorJS.PixiJS
{
    public static partial class PIXI
    {
        /// <summary>
        /// The Circle object is using to represent a circle with a radius and a position (x, y).<br/>
        /// https://pixijs.download/v8.14.3/docs/maths.Circle.html
        /// </summary>
        public class Circle : JSObject
        {
            /// <summary>
            /// Deserialization constructor
            /// </summary>
            public Circle(IJSInProcessObjectReference _ref) : base(_ref) { }
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            /// <param name="x">The X coordinate of the center of this circle</param>
            /// <param name="y">The Y coordinate of the center of this circle</param>
            /// <param name="radius">The radius of the circle</param>
            public Circle(float x = 0, float y = 0, float radius = 0) : base(JS.New("PIXI.Circle", x, y, radius)) { }
            
            /// <summary>
            /// The X coordinate of the center of this circle
            /// </summary>
            public float X { get => JSRef!.Get<float>("x"); set => JSRef!.Set("x", value); }
            
            /// <summary>
            /// The Y coordinate of the center of this circle
            /// </summary>
            public float Y { get => JSRef!.Get<float>("y"); set => JSRef!.Set("y", value); }
            
            /// <summary>
            /// The radius of the circle
            /// </summary>
            public float Radius { get => JSRef!.Get<float>("radius"); set => JSRef!.Set("radius", value); }
        }
    }
}
