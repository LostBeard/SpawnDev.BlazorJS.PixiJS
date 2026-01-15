using SpawnDev.BlazorJS.JSObjects;
using System.Text.Json.Serialization;

namespace SpawnDev.BlazorJS.PixiJS
{
    public static partial class PIXI
    {
        /// <summary>
        /// Options for HTMLTextStyle.<br/>
        /// https://pixijs.download/v8.14.3/docs/scene.HTMLTextStyleOptions.html
        /// </summary>
        public class HTMLTextStyleOptions : TextStyleOptions
        {
             // HTMLTextStyle mostly shares TextStyleOptions but can have specific overrides or tag styles.
             // For now, inheriting TextStyleOptions provides the base properties.
             // If PIXI v8 introduces specific HTML properties, they would go here.
             
             // Example: cssOverrides, which might be a dictionary or object.
             // [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
             // public Dictionary<string, string>? CssOverrides { get; set; }
        }
    }
}
