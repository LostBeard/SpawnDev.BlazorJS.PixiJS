using SpawnDev.BlazorJS.JSObjects;
using Microsoft.JSInterop;

namespace SpawnDev.BlazorJS.PixiJS
{
    public static partial class PIXI
    {
        /// <summary>
        /// Options for the HTMLText constructor.
        /// </summary>
        public class HTMLTextOptions : JSObject
        {
            /// <summary>
            /// Deserialization constructor
            /// </summary>
            public HTMLTextOptions(IJSInProcessObjectReference _ref) : base(_ref) { }
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public HTMLTextOptions() : base(JS.New("Object")) { }

            /// <summary>
            /// The text to render.
            /// </summary>
            public string Text { get => JSRef!.Get<string>("text"); set => JSRef!.Set("text", value); }
            public HTMLTextStyle Style { get => JSRef!.Get<HTMLTextStyle>("style"); set => JSRef!.Set("style", value); }
        }
    }
}
