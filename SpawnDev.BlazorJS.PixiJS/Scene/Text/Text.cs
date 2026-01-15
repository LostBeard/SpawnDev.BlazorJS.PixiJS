using Microsoft.JSInterop;

namespace SpawnDev.BlazorJS.PixiJS
{
    public static partial class PIXI
    {
        /// <summary>
        /// A Text Object will create a line or multiple lines of text.
        /// https://pixijs.download/release/docs/scene.Text.html
        /// </summary>
        public class Text : AbstractText, IView
        {
            /// <inheritdoc/>
            public Text(IJSInProcessObjectReference _ref) : base(_ref) { }
            /// <summary>
            /// Creates a new instance
            /// </summary>
            /// <param name="text"></param>
            /// <param name="style"></param>
            public Text(string text, TextStyle style) : base(JS.New("PIXI.Text", text, style)) { }
            /// <summary>
            /// Creates a new instance
            /// </summary>
            /// <param name="text"></param>
            /// <param name="style"></param>
            public Text(string text, TextStyleOptions style) : base(JS.New("PIXI.Text", text, style)) { }
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public Text(TextOptions textOptions) : base(JS.New("PIXI.Text", textOptions)) { }
        }
    }
}
