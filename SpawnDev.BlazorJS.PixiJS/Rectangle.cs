using Microsoft.JSInterop;

namespace SpawnDev.BlazorJS.PixiJS
{
    public static partial class PIXI
    {
        /// <summary>
        /// The `Rectangle` object is an area defined by its position, as indicated by its top-left corner point(`x`, `y`) and by its `width` and its `height`.<br/>
        /// implements ShapePrimitive
        /// </summary>
        public class Rectangle : JSObject
        {
            /// <summary>
            /// Deserialization constructor
            /// </summary>
            /// <param name="_ref"></param>
            public Rectangle(IJSInProcessObjectReference _ref) : base(_ref) { }
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public Rectangle(float x, float y, float width, float height) : base(JS.New("PIXI.Rectangle", x, y, width, height)) { }
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public Rectangle() : base(JS.New("PIXI.Rectangle")) { }
            #region Properties
            public float X { get => JSRef!.Get<float>("x"); set => JSRef!.Set("x", value); }
            public float Y { get => JSRef!.Get<float>("y"); set => JSRef!.Set("y", value); }
            public float Width { get => JSRef!.Get<float>("width"); set => JSRef!.Set("width", value); }
            public float Height { get => JSRef!.Get<float>("height"); set => JSRef!.Set("height", value); }
            #endregion
        }
    }
}
