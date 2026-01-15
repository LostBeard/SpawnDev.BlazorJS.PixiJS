using Microsoft.JSInterop;

namespace SpawnDev.BlazorJS.PixiJS
{
    public static partial class PIXI
    {
        /// <summary>
        /// A filter is a special shader that allows you to apply separate visual effects to a display object.<br/>
        /// https://pixijs.download/v8.14.3/docs/filters.Filter.html
        /// </summary>
        public class Filter : JSObject
        {
            /// <summary>
            /// Deserialization constructor
            /// </summary>
            public Filter(IJSInProcessObjectReference _ref) : base(_ref) { }
            
            /// <summary>
            /// Creates a new Filter instance.
            /// </summary>
            /// <param name="options">The options for the filter.</param>
            public Filter(object? options = null) : base(JS.New("PIXI.Filter", options)) { }
            
            /// <summary>
            /// If enabled is true the filter is applied, if false it will not.
            /// </summary>
            public bool Enabled { get => JSRef!.Get<bool>("enabled"); set => JSRef!.Set("enabled", value); }
            public float Resolution { get => JSRef!.Get<float>("resolution"); set => JSRef!.Set("resolution", value); }
            public float Padding { get => JSRef!.Get<float>("padding"); set => JSRef!.Set("padding", value); }
            public bool AntiAlias { get => JSRef!.Get<bool>("antialias"); set => JSRef!.Set("antialias", value); }
            public int BlendMode { get => JSRef!.Get<int>("blendMode"); set => JSRef!.Set("blendMode", value); }
        }
    }
}
