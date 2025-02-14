using System.Text.Json.Serialization;

namespace SpawnDev.BlazorJS.PixiJS
{
    public static partial class PIXI
    {
        /// <summary>
        /// A drop shadow effect.
        /// </summary>
        public class TextDropShadow
        {
            /// <summary>
            /// Set alpha for the drop shadow 
            /// </summary>
            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
            public float? Alpha { get; set; }
            /// <summary>
            /// Set a angle of the drop shadow
            /// </summary>
            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
            public float? Angle { get; set; }
            /// <summary>
            /// Set a shadow blur radius
            /// </summary>
            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
            public float? Blur { get; set; }
            /// <summary>
            /// A fill style to be used on the  e.g., 'red', '#00FF00'
            /// </summary>
            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
            public ColorSource? Color { get; set; }
            /// <summary>
            /// Set a distance of the drop shadow 
            /// </summary>
            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
            public float? Distance { get; set; }
        }
    }
}
