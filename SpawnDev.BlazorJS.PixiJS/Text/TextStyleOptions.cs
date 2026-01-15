using SpawnDev.BlazorJS.JSObjects;
using System.Text.Json.Serialization;

namespace SpawnDev.BlazorJS.PixiJS
{
    public static partial class PIXI
    {
        /// <summary>
        /// Constructor options used for TextStyle instances.<br/>
        /// https://pixijs.download/release/docs/text.TextStyleOptions.html
        /// </summary>
        public class TextStyleOptions
        {
            /// <summary>
            /// Alignment for multiline text, does not affect single line text<br/>
            /// 'left' | 'center' | 'right' | 'justify'	
            /// </summary>
            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
            public string? Align { get; set; }
            /// <summary>
            /// Indicates if lines can be wrapped within words, it needs wordWrap to be set to true
            /// </summary>
            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
            public bool? BreakWords { get; set; }
            /// <summary>
            /// Set a drop shadow for the text
            /// </summary>
            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
            public Union<bool, TextDropShadow>? DropShadow { get; set; }
            /// <summary>
            /// A canvas fillstyle that will be used on the text e.g., 'red', '#00FF00'. Can be an array to create a gradient, e.g., ['#000000','#FFFFFF'] MDN
            /// </summary>
            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
            public Union<string, string[], float, float[], CanvasGradient, CanvasPattern>? Fill { get; set; }
            /// <summary>
            /// The font family, can be a single font name, or a list of names where the first is the preferred font.
            /// </summary>
            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
            public string? FontFamily { get; set; }
            /// <summary>
            /// The font size (as a number it converts to px, but as a string, equivalents are '26px','20pt','160%' or '1.6em')
            /// </summary>
            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
            public Union<float, string>? FontSize { get; set; }
            /// <summary>
            /// The font style.<br/>
            /// 'normal' | 'italic' | 'oblique'	
            /// </summary>
            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
            public string? FontStyle { get; set; }
            /// <summary>
            /// The font variant.<br/>
            /// 'normal' | 'small-caps'	
            /// </summary>
            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
            public string? FontVariant { get; set; }
            /// <summary>
            /// The font weight.<br/>
            /// 'normal' | 'bold' | 'bolder' | 'lighter' | '100' | '200' | '300' | '400' | '500' | '600' | '700' | '800' | '900'	
            /// </summary>
            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
            public string? FontWeight { get; set; }
            /// <summary>
            /// The height of the line, a number that represents the vertical space that a letter uses.
            /// </summary>
            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
            public float? Leading { get; set; }
            /// <summary>
            /// The amount of spacing between letters, default is 0
            /// </summary>
            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
            public float? LetterSpacing { get; set; }
            /// <summary>
            /// The line height, a number that represents the vertical space that a letter uses
            /// </summary>
            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
            public float? LineHeight { get; set; }
            /// <summary>
            /// Occasionally some fonts are cropped. Adding some padding will prevent this from happening by adding padding to all sides of the text.
            /// </summary>
            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
            public float? Padding { get; set; }
            /// <summary>
            /// A canvas fillstyle that will be used on the text stroke, e.g., 'blue', '#FCFF00'
            /// </summary>
            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
            public Union<string, StrokeStyle>? Stroke { get; set; }
            /// <summary>
            /// The baseline of the text that is rendered.<br/>
            /// 'alphabetic' | 'top' | 'hanging' | 'middle' | 'ideographic' | 'bottom'	
            /// </summary>
            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
            public string? TextBaseline { get; set; }
            /// <summary>
            /// Determines whether newlines and spaces are collapsed or preserved "normal" (collapse, collapse), "pre" (preserve, preserve) | "pre-line" (preserve, collapse). It needs wordWrap to be set to true.<br/>
            /// 'normal' | 'pre' | 'pre-line'	
            /// </summary>
            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
            public string? WhiteSpace { get; set; }
            /// <summary>
            /// Indicates if word wrap should be used
            /// </summary>
            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
            public bool? WordWrap { get; set; }
            /// <summary>
            /// The width at which text will wrap, it needs wordWrap to be set to true
            /// </summary>
            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
            public float? WordWrapWidth { get; set; }
        }
    }
}
