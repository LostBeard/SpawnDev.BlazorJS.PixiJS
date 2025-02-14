using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpawnDev.BlazorJS.PixiJS
{
    public static partial class PIXI
    {
        public class Text : AbstractText, IView
        {
            /// <inheritdoc/>
            public Text(IJSInProcessObjectReference _ref) : base(_ref) { }
            /// <summary>
            /// Creates a new instance
            /// </summary>
            /// <param name="text"></param>
            /// <param name="style"></param>
            public Text(string text, TextStyle style) : base(JS.New("PIXI.BitmapText", text, style)) { }
            /// <summary>
            /// Creates a new instance
            /// </summary>
            /// <param name="text"></param>
            /// <param name="style"></param>
            public Text(string text, TextStyleOptions style) : base(JS.New("PIXI.BitmapText", text, style)) { }
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public Text(TextOptions textOptions) : base(JS.New("PIXI.BitmapText", textOptions)) { }
        }
    }
}
