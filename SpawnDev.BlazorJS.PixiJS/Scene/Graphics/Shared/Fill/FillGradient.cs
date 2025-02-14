using Microsoft.JSInterop;
using SpawnDev.BlazorJS.JSObjects;
using System.Xml.Linq;

namespace SpawnDev.BlazorJS.PixiJS
{
    public static partial class PIXI
    {
        public class TextureSpace
        {

        }
        public class GradientOptions
        {


        }
        public class RadialGradientOptions
        {


        }
        public class LinearGradientOptions
        {


        }
        public class FillGradient : CanvasGradient
        {
            /// <inheritdoc/>
            public FillGradient(IJSInProcessObjectReference _ref) : base(_ref) { }
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public FillGradient(RadialGradientOptions options) : base(JS.New("PIXI.FillGradient", options)) { }
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public FillGradient(LinearGradientOptions options) : base(JS.New("PIXI.FillGradient", options)) { }
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public FillGradient(float x0, float y0, float x1, float y1, TextureSpace textureSpace, float textureSize) : base(JS.New("PIXI.FillGradient", x0, y0, x1, y1, textureSpace, textureSize)) { }
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public FillGradient(float x0, float y0, float x1, float y1, TextureSpace textureSpace) : base(JS.New("PIXI.FillGradient", x0, y0, x1, y1, textureSpace)) { }
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public FillGradient(float x0, float y0, float x1, float y1) : base(JS.New("PIXI.FillGradient", x0, y0, x1, y1)) { }

            /// <summary>
            /// Adds a color stop to the gradient
            /// </summary>
            public void AddColorStop(float offset, ColorSource color) => JSRef!.CallVoid("addColorStop", offset, color);
        }
    }
}
