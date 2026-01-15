using Microsoft.JSInterop;

namespace SpawnDev.BlazorJS.PixiJS
{
    public static partial class PIXI
    {
        /// <summary>
        /// The ColorMatrixFilter class lets you apply a 5x4 matrix transformation on the RGBA color and alpha values.<br/>
        /// https://pixijs.download/v8.14.3/docs/filters.ColorMatrixFilter.html
        /// </summary>
        public class ColorMatrixFilter : Filter
        {
            /// <summary>
            /// Deserialization constructor
            /// </summary>
            public ColorMatrixFilter(IJSInProcessObjectReference _ref) : base(_ref) { }
            
            /// <summary>
            /// Creates a new ColorMatrixFilter instance.
            /// </summary>
            public ColorMatrixFilter() : base(JS.New("PIXI.ColorMatrixFilter")) { }
            
            /// <summary>
            /// Adjusts brightness.
            /// </summary>
            /// <param name="b">value of the brightness (0-1, where 1 is 100%)</param>
            /// <param name="multiply">whether to multiply or replace</param>
            public void Brightness(float b, bool multiply = false) => JSRef!.CallVoid("brightness", b, multiply);
            public void Tint(float color, bool multiply = false) => JSRef!.CallVoid("tint", color, multiply);
            public void Greyscale(float scale, bool multiply = false) => JSRef!.CallVoid("greyscale", scale, multiply);
            public void BlackAndWhite(bool multiply = false) => JSRef!.CallVoid("blackAndWhite", multiply);
            public void Hue(float rotation, bool multiply = false) => JSRef!.CallVoid("hue", rotation, multiply);
            public void Contrast(float amount, bool multiply = false) => JSRef!.CallVoid("contrast", amount, multiply);
            public void Saturate(float amount, bool multiply = false) => JSRef!.CallVoid("saturate", amount, multiply);
            public void Desaturate(bool multiply = false) => JSRef!.CallVoid("desaturate", multiply);
            public void Negative(bool multiply = false) => JSRef!.CallVoid("negative", multiply);
            public void Sepia(bool multiply = false) => JSRef!.CallVoid("sepia", multiply);
            public void Technicolor(bool multiply = false) => JSRef!.CallVoid("technicolor", multiply);
            public void Polaroid(bool multiply = false) => JSRef!.CallVoid("polaroid", multiply);
            public void ToBGR(bool multiply = false) => JSRef!.CallVoid("toBGR", multiply);
            public void Kodachrome(bool multiply = false) => JSRef!.CallVoid("kodachrome", multiply);
            public void Browni(bool multiply = false) => JSRef!.CallVoid("browni", multiply);
            public void Vintage(bool multiply = false) => JSRef!.CallVoid("vintage", multiply);
            public void ColorTone(float desaturation, float toned, float lightColor, float darkColor, bool multiply = false) => JSRef!.CallVoid("colorTone", desaturation, toned, lightColor, darkColor, multiply);
            public void Night(float intensity, bool multiply = false) => JSRef!.CallVoid("night", intensity, multiply);
            public void Predator(float amount, bool multiply = false) => JSRef!.CallVoid("predator", amount, multiply);
            public void Lsd(bool multiply = false) => JSRef!.CallVoid("lsd", multiply);
            public void Reset() => JSRef!.CallVoid("reset");
        }
    }
}
