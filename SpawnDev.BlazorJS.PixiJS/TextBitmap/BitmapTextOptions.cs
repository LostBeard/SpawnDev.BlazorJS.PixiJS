using Microsoft.JSInterop;

namespace SpawnDev.BlazorJS.PixiJS
{
    public static partial class PIXI
    {
        /// <summary>
        /// Options for the BitmapText constructor.
        /// </summary>
        public class BitmapTextOptions : JSObject
        {
            /// <summary>
            /// Deserialization constructor
            /// </summary>
            public BitmapTextOptions(IJSInProcessObjectReference _ref) : base(_ref) { }

            /// <summary>
            /// Creates a new instance
            /// </summary>
            public BitmapTextOptions() : base(JS.New("Object")) { }

            /// <summary>
            /// The text to display.
            /// </summary>
            public string? Text { get => JSRef!.Get<string?>("text"); set => JSRef!.Set("text", value); }

            /// <summary>
            /// The style object.
            /// </summary>
            public TextStyle? Style { get => JSRef!.Get<TextStyle?>("style"); set => JSRef!.Set("style", value); }
            /// <summary>
            /// The resolution of the text.
            /// </summary>
            public float? Resolution { get => JSRef!.Get<float?>("resolution"); set => JSRef!.Set("resolution", value); }
        }
    }
}
