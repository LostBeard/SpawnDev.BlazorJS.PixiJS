using Microsoft.JSInterop;

namespace SpawnDev.BlazorJS.PixiJS
{
    public static partial class PIXI
    {
        /// <summary>
        /// The Rounded Rectangle object is an area defined by its position, as indicated by its top-left corner point (x, y) and by its width and its height, including a corner radius.<br/>
        /// https://pixijs.download/v8.14.3/docs/maths.RoundedRectangle.html
        /// </summary>
        public class RoundedRectangle : JSObject
        {
            /// <summary>
            /// Deserialization constructor
            /// </summary>
            public RoundedRectangle(IJSInProcessObjectReference _ref) : base(_ref) { }
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            /// <param name="x">The X coordinate of the upper-left corner of the rounded rectangle</param>
            /// <param name="y">The Y coordinate of the upper-left corner of the rounded rectangle</param>
            /// <param name="width">The overall width of this rounded rectangle</param>
            /// <param name="height">The overall height of this rounded rectangle</param>
            /// <param name="radius">Controls the radius of the rounded corners</param>
            public RoundedRectangle(float x = 0, float y = 0, float width = 0, float height = 0, float radius = 20) : base(JS.New("PIXI.RoundedRectangle", x, y, width, height, radius)) { }
            
            /// <summary>
            /// The X coordinate of the upper-left corner of the rounded rectangle
            /// </summary>
            public float X { get => JSRef!.Get<float>("x"); set => JSRef!.Set("x", value); }
            
            /// <summary>
            /// The Y coordinate of the upper-left corner of the rounded rectangle
            /// </summary>
            public float Y { get => JSRef!.Get<float>("y"); set => JSRef!.Set("y", value); }
            
            /// <summary>
            /// The overall width of this rounded rectangle
            /// </summary>
            public float Width { get => JSRef!.Get<float>("width"); set => JSRef!.Set("width", value); }
            
            /// <summary>
            /// The overall height of this rounded rectangle
            /// </summary>
            public float Height { get => JSRef!.Get<float>("height"); set => JSRef!.Set("height", value); }
            
            /// <summary>
            /// Controls the radius of the rounded corners
            /// </summary>
            public float Radius { get => JSRef!.Get<float>("radius"); set => JSRef!.Set("radius", value); }
        }
    }
}
