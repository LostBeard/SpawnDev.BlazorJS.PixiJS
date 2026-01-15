using Microsoft.JSInterop;

namespace SpawnDev.BlazorJS.PixiJS
{
    public static partial class PIXI
    {
        /// <summary>
        /// A pattern filler
        /// https://pixijs.download/release/docs/scene.FillPattern.html
        /// </summary>
        public class FillPattern : JSObject
        {
            /// <inheritdoc/>
            public FillPattern(IJSInProcessObjectReference _ref) : base(_ref) { }
        }
    }
}
