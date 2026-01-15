using System.Text.Json.Serialization;

namespace SpawnDev.BlazorJS.PixiJS
{
    public static partial class PIXI
    {
        /// <summary>
        /// Options for Text
        /// </summary>
        public class TextOptions
        {
            /// <summary>
            /// The text to display
            /// </summary>
            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
            public string? Text { get; set; }

            /// <summary>
            /// The style of the text
            /// </summary>
            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
            public Union<TextStyleOptions, TextStyle>? Style { get; set; }
        }
    }
}
