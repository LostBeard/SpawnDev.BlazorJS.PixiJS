using Microsoft.JSInterop;

namespace SpawnDev.BlazorJS.PixiJS
{
    public static partial class PIXI
    {
        /// <summary>
        /// A BitmapText object will create a line or multiple lines of text using bitmap font.<br/>
        /// The primary advantage of this class over Text is that all of your textures are pre-generated and loading, meaning that rendering fast, and changing text has no performance implications.<br/>
        /// https://pixijs.download/v8.7.1/docs/scene.BitmapText.html
        /// </summary>
        public class BitmapText : AbstractText, IView
        {
            #region Constructors
            /// <summary>
            /// Deserialization constructor
            /// </summary>
            /// <param name="_ref"></param>
            public BitmapText(IJSInProcessObjectReference _ref) : base(_ref) { }
            /// <summary>
            /// Creates a new instance
            /// </summary>
            /// <param name="options"></param>
            public BitmapText(BitmapTextOptions options) : base(JS.New("PIXI.BitmapText", options)) { }

            /// <summary>
            /// Creates a new instance
            /// </summary>
            /// <param name="text"></param>
            /// <param name="style"></param>
            public BitmapText(string text, TextStyle style) : this(new BitmapTextOptions { Text = text, Style = style }) { }
            /// <summary>
            /// Creates a new instance
            /// </summary>
            /// <param name="text"></param>
            /// <param name="style"></param>
            public BitmapText(string text, TextStyleOptions style) : this(new BitmapTextOptions { Text = text, Style = style }) { }
            #endregion
            #region Properties
            /// <summary>
            /// The alignment of the BitmapText object.
            /// </summary>
            public string Align { get => JSRef!.Get<string>("align"); set => JSRef!.Set("align", value); }
            /// <summary>
            /// The width of the overall text, different from fontSize, which is defined in the style object.
            /// </summary>
            public float TextWidth => JSRef!.Get<float>("textWidth");
            /// <summary>
            /// The height of the overall text, different from fontSize, which is defined in the style object.
            /// </summary>
            public float TextHeight => JSRef!.Get<float>("textHeight");
            /// <summary>
            /// The text to display.
            /// </summary>
            public string Text { get => JSRef!.Get<string>("text"); set => JSRef!.Set("text", value); }
            /// <summary>
            /// The max width of the text before line wrapping.
            /// </summary>
            public float MaxWidth { get => JSRef!.Get<float>("maxWidth"); set => JSRef!.Set("maxWidth", value); }
            /// <summary>
            /// The letter spacing of the text.
            /// </summary>
            public float LetterSpacing { get => JSRef!.Get<float>("letterSpacing"); set => JSRef!.Set("letterSpacing", value); }

            #endregion
            #region Methods
            /// <summary>
            /// Updates the transform on all children of this container for rendering.
            /// </summary>
            public void UpdateTransform() => JSRef!.CallVoid("updateTransform");

            #endregion

            #region View Interface

            /// <summary>
            /// Adds the current bounds of this view to the supplied bounds
            /// </summary>
            /// <param name="bounds"></param>
            /// <exception cref="NotImplementedException"></exception>
            public void AddBounds(Bounds bounds) => JSRef!.CallVoid("addBounds", bounds);

            #endregion
        }
    }
}
