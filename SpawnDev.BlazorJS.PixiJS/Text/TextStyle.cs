using Microsoft.JSInterop;

namespace SpawnDev.BlazorJS.PixiJS
{
    public static partial class PIXI
    {
        /// <summary>
        /// A TextStyle Object contains information to decorate a Text objects.<br/>
        /// An instance can be shared between multiple Text objects; then changing the style will update all text objects using it.
        /// https://pixijs.download/release/docs/text.TextStyle.html
        /// </summary>
        public class TextStyle : JSObject
        {
            /// <inheritdoc/>
            public TextStyle(IJSInProcessObjectReference _ref) : base(_ref) { }
            /// <summary>
            /// Create a new instance
            /// </summary>
            /// <param name="options"></param>
            public TextStyle(TextStyleOptions options) : base(JS.New("PIXI.TextStyle", options)) { }
            /// <summary>
            /// Create a new instance
            /// </summary>
            public TextStyle() : base(JS.New("PIXI.TextStyle")) { }
            /// <summary>
            /// Alignment for multiline text, does not affect single line text.<br/>
            /// 'left' | 'center' | 'right' | 'justify'
            /// </summary>
            public string? Align { get => JSRef!.Get<string?>("align"); set => JSRef!.Set("align", value); }
            /// <summary>
            /// Indicates if lines can be wrapped within words, it needs wordWrap to be set to true.
            /// </summary>
            public bool BreakWords { get => JSRef!.Get<bool>("breakWords"); set => JSRef!.Set("breakWords", value); }
            /// <summary>
            /// Set a drop shadow for the text.
            /// </summary>
            public TextDropShadow? DropShadow { get => JSRef!.Get<TextDropShadow?>("dropShadow"); set => JSRef!.Set("dropShadow", value); }
            /// <summary>
            /// The fill style that will be used to color the text.<br/>
            /// A color string like 'red', '#00FF00', or 'rgba(255,0,0,0.5)'<br/>
            /// A hex number like 0xff0000 for red<br/>
            /// A FillStyle object with properties like { color: 0xff0000, alpha: 0.5 }<br/>
            /// A FillGradient for gradient fills<br/>
            /// A FillPattern for pattern/texture fills<br/>
            /// string | number | FillStyle | FillGradient | FillPattern
            /// </summary>
            public Union<string, float, FillGradient, FillPattern, IFillStyle>? Fill { get => JSRef!.Get<Union<string, float, FillGradient, FillPattern, IFillStyle>?>("fill"); set => JSRef!.Set("fill", value); }
            /// <summary>
            /// The font family, can be a single font name, or a list of names where the first is the preferred font.
            /// </summary>
            public Union<string, string[]>? FontFamily { get => JSRef!.Get<Union<string, string[]>?>("fontFamily"); set => JSRef!.Set("fontFamily", value); }
            /// <summary>
            /// The font size (as a number it converts to px, but as a string, equivalents are '26px','20pt','160%' or '1.6em')
            /// </summary>
            public float FontSize { get => JSRef!.Get<float>("fontSize"); set => JSRef!.Set("fontSize", value); }
            /// <summary>
            /// The font style.<br/>
            /// 'normal' | 'italic' | 'oblique'
            /// </summary>
            public string? FontStyle { get => JSRef!.Get<string?>("fontStyle"); set => JSRef!.Set("fontStyle", value); }
            /// <summary>
            /// The font variant.<br/>
            /// 'normal' | 'small-caps'
            /// </summary>
            public string? FontVariant { get => JSRef!.Get<string?>("fontVariant"); set => JSRef!.Set("fontVariant", value); }
            /// <summary>
            /// The font weight.<br/>
            /// 'normal' | 'bold' | 'bolder' | 'lighter' | '100' | '200' | '300' | '400' | '500' | '600' | '700' | '800' | '900'
            /// </summary>
            public string? FontWeight { get => JSRef!.Get<string?>("fontWeight"); set => JSRef!.Set("fontWeight", value); }
            /// <summary>
            /// The space between lines.
            /// </summary>
            public float Leading { get => JSRef!.Get<float>("leading"); set => JSRef!.Set("leading", value); }
            /// <summary>
            /// The amount of spacing between letters, default is 0.
            /// </summary>
            public float LetterSpacing { get => JSRef!.Get<float>("letterSpacing"); set => JSRef!.Set("letterSpacing", value); }
            /// <summary>
            /// The line height, a number that represents the vertical space that a letter uses.
            /// </summary>
            public float LineHeight { get => JSRef!.Get<float>("lineHeight"); set => JSRef!.Set("lineHeight", value); }
            /// <summary>
            /// Occasionally some fonts are cropped. Adding some padding will prevent this from happening by adding padding to all sides of the text.
            /// </summary>
            public float Padding { get => JSRef!.Get<float>("padding"); set => JSRef!.Set("padding", value); }
            /// <summary>
            /// A fillstyle that will be used on the text stroke, e.g., 'blue', '#FCFF00'.
            /// </summary>
            public string? Stroke { get => JSRef!.Get<string?>("stroke"); set => JSRef!.Set("stroke", value); }
            /// <summary>
            /// The baseline of the text that is rendered.<br/>
            /// 'alphabetic' | 'top' | 'hanging' | 'middle' | 'ideographic' | 'bottom'
            /// </summary>
            public string? TextBaseline { get => JSRef!.Get<string?>("textBaseline"); set => JSRef!.Set("textBaseline", value); }
            /// <summary>
            /// Trim transparent borders. This is an expensive operation so only use this if you have to!
            /// </summary>
            public bool Trim { get => JSRef!.Get<bool>("trim"); set => JSRef!.Set("trim", value); }
            /// <summary>
            /// How newlines and spaces should be handled. Default is 'pre' (preserve, preserve).<br/>
            /// 'normal' | 'pre' | 'pre-line'
            /// </summary>
            public string? WhiteSpace { get => JSRef!.Get<string?>("whiteSpace"); set => JSRef!.Set("whiteSpace", value); }
            /// <summary>
            /// Indicates if word wrap should be used.
            /// </summary>
            public bool WordWrap { get => JSRef!.Get<bool>("wordWrap"); set => JSRef!.Set("wordWrap", value); }
            /// <summary>
            /// The width at which text will wrap, it needs wordWrap to be set to true.
            /// </summary>
            public float WordWrapWidth { get => JSRef!.Get<float>("wordWrapWidth"); set => JSRef!.Set("wordWrapWidth", value); }
            /// <summary>
            /// Creates a new TextStyle object with the same values as this one.
            /// </summary>
            /// <returns>New cloned TextStyle objec</returns>
            public TextStyle Clone() => JSRef!.Call<TextStyle>("clone");
            /// <summary>
            /// Destroys this text style.
            /// </summary>
            public void Destroy() => JSRef!.CallVoid("destroy");
            /// <summary>
            /// Resets all properties to the default values
            /// </summary>
            public void Reset() => JSRef!.CallVoid("reset");
        }
    }
}
