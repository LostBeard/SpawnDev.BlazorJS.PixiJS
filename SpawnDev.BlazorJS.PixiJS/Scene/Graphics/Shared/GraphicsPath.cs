using Microsoft.JSInterop;

namespace SpawnDev.BlazorJS.PixiJS
{
    public static partial class PIXI
    {
        /// <summary>
        /// A class to define a shape via an appropriate array of coordinates.
        /// https://pixijs.download/release/docs/scene.GraphicsPath.html
        /// </summary>
        public class GraphicsPath : JSObject
        {

            /// <inheritdoc/>
            public GraphicsPath(IJSInProcessObjectReference _ref) : base(_ref) { }
        }
    }
}
