using Microsoft.JSInterop;

namespace SpawnDev.BlazorJS.PixiJS
{
    public static partial class PIXI
    {
        /// <summary>
        /// HTMLText is a logical object that renders HTML text.<br/>
        /// https://pixijs.download/v8.14.3/docs/scene.HTMLText.html
        /// </summary>
        public class HTMLText : Text
        {
            /// <summary>
            /// Deserialization constructor
            /// </summary>
            public HTMLText(IJSInProcessObjectReference _ref) : base(_ref) { }
            /// <summary>
            /// Creates a new HTMLText instance.
            /// </summary>
            /// <param name="options">The options to use.</param>
            public HTMLText(HTMLTextOptions options) : base(JS.New("PIXI.HTMLText", options)) { }

            /// <summary>
            /// Creates a new HTMLText instance.
            /// </summary>
            /// <param name="text">The text to render.</param>
            /// <param name="style">The style to reuse.</param>
            public HTMLText(string text, HTMLTextStyle? style = null)
                : this(new HTMLTextOptions { Text = text, Style = style ?? new HTMLTextStyle() }) { }

            // HTMLText behaves very similar to Text but uses DOM overlay/foreignObject
        }
    }
}
