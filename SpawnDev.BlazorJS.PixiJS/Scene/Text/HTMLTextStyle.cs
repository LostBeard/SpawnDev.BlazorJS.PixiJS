using Microsoft.JSInterop;

namespace SpawnDev.BlazorJS.PixiJS
{
    public static partial class PIXI
    {
        /// <summary>
        /// A TextStyle that renders HTML text.<br/>
        /// https://pixijs.download/v8.14.3/docs/scene.HTMLTextStyle.html
        /// </summary>
        public class HTMLTextStyle : TextStyle
        {
            /// <summary>
            /// Deserialization constructor
            /// </summary>
            public HTMLTextStyle(IJSInProcessObjectReference _ref) : base(_ref) { }
            
            /// <summary>
            /// Creates a new HTMLTextStyle instance.
            /// </summary>
            public HTMLTextStyle() : base(JS.New("PIXI.HTMLTextStyle")) { }
            // HTMLTextStyle often inherits mostly from TextStyle but renders differently
            // Check docs if it has specific extra properties basically allows CSS logic
        }
    }
}
