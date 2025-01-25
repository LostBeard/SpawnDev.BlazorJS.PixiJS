using Microsoft.AspNetCore.Components;
using SpawnDev.BlazorJS.JSObjects;
using System.Text.Json.Serialization;

namespace SpawnDev.BlazorJS.PixiJS
{
    public static partial class PIXI
    {
        /// <summary>
        /// Application options supplied to the init method.<br/>
        /// https://pixijs.download/release/docs/app.ApplicationOptions.html
        /// https://pixijs.download/dev/docs/app.ApplicationOptions.html
        /// </summary>
        public class ApplicationOptions : AutoDetectOptions
        {
            /// <summary>
            /// The background color used to clear the canvas. See {@link ColorSource} for accepted color values.
            /// interface BackgroundSystemOptions
            /// </summary>
            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
            public ColorSource? BackgroundColor { get; set; }
            /// <summary>
            /// Alias for backgroundColor
            /// interface BackgroundSystemOptions
            /// </summary>
            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
            public ColorSource? Background { get; set; }
            /// <summary>
            /// Transparency of the background color, value from `0` (fully transparent) to `1` (fully opaque).<br/>
            /// default 1<br/>
            /// interface BackgroundSystemOptions
            /// </summary>
            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
            public float? BackgroundAlpha { get; set; }
            /// <summary>
            /// Whether to clear the canvas before new render passes.<br/>
            /// default true<br/>
            /// interface BackgroundSystemOptions
            /// </summary>
            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
            public bool? ClearBeforeRender { get; set; }
            /// <summary>
            /// Sets antialias
            /// </summary>
            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
            public bool? Antialias { get; set; }
            /// <summary>
            /// Element to automatically resize the renderer to.
            /// interface ResizePluginOptions
            /// </summary>
            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
            public Union<Window, HTMLElement, ElementReference>? ResizeTo { get; set; }
            /// <summary>
            /// Automatically starts the rendering after the construction. Note: Setting this parameter to false does NOT stop the shared ticker even if you set options.sharedTicker to true in case that it is already started. Stop it by your own.<br/>
            /// default true<br/>
            /// interface TickerPluginOptions
            /// </summary>
            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
            public bool? AutoStart { get; set; }
            /// <summary>
            /// Set true to use Ticker.shared, false to create new ticker. If set to false, you cannot register a handler to occur before anything that runs on the shared ticker. The system ticker will always run before both the shared ticker and the app ticker.<br/>
            /// default false<br/>
            /// interface TickerPluginOptions
            /// </summary>
            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
            public bool? SharedTicker { get; set; }


        }
    }
}
