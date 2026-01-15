using Microsoft.JSInterop;

namespace SpawnDev.BlazorJS.PixiJS
{
    public static partial class PIXI
    {
        public class TextureOptions : JSObject
        {
            /// <summary>
            /// Deserialization constructor
            /// </summary>
            public TextureOptions(IJSInProcessObjectReference _ref) : base(_ref) { }
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public TextureOptions() : base(JS.New("Object")) { }

            // Add properties as needed based on PixiJS docs
            // public string? ScaleMode { get => JSRef!.Get<string?>("scaleMode"); set => JSRef!.Set("scaleMode", value); }
        }
    }
}
