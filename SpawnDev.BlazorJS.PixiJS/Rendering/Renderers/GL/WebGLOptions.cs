using SpawnDev.BlazorJS.JsonConverters;
using System.Text.Json.Serialization;

namespace SpawnDev.BlazorJS.PixiJS
{
    public static partial class PIXI
    {
        /// <summary>
        /// Options for WebGLRenderer.<br/>
        /// https://pixijs.download/release/docs/rendering.WebGLOptions.html
        /// </summary>
        public class WebGLOptions : SharedRendererOptions
        {
            /// <summary>
            /// if true will use the back buffer where required
            /// </summary>
            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
            public bool? UseBackBuffer { get; set; }
        }
    }
}
