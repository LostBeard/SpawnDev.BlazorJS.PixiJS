using Microsoft.JSInterop;

namespace SpawnDev.BlazorJS.PixiJS
{
    public static partial class PIXI
    {
        /// <summary>
        /// A view is something that is able to be rendered by the renderer.
        /// </summary>
        public class Color : JSObject
        {
            /// <inheritdoc/>
            public Color(IJSInProcessObjectReference _ref) : base(_ref) { }
            /// <summary>
            /// Default Color object for static uses
            /// </summary>
            public static Color Shared => JS.Get<Color>("PIXI.Color.shared");
            /// <summary>
            /// Set the color value
            /// </summary>
            /// <param name="value"></param>
            /// <returns></returns>
            public Color SetValue(ColorSource value) => JSRef!.Call<Color>("setValue", value);
            /// <summary>
            /// Returns the color as an integer
            /// </summary>
            /// <returns></returns>
            public int ToNumber() => JSRef!.Call<int>("toNumber");
        }
    }
}
