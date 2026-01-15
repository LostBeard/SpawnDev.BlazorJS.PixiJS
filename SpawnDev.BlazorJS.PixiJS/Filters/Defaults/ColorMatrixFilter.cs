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
            /// <summary>
            /// Sets the matrix of the color matrix filter.
            /// </summary>
            /// <param name="color">The color to tint the image.</param>
            /// <param name="multiply">Whether to multiply or replace.</param>
            public void Tint(float color, bool multiply = false) => JSRef!.CallVoid("tint", color, multiply);
            /// <summary>
            /// Set the grey scale of the matrix.
            /// </summary>
            /// <param name="scale">value of the grey (0-1, where 1 is 100%)</param>
            /// <param name="multiply">whether to multiply or replace</param>
            public void Greyscale(float scale, bool multiply = false) => JSRef!.CallVoid("greyscale", scale, multiply);
            /// <summary>
            /// Set the black and white of the matrix.
            /// </summary>
            /// <param name="multiply">whether to multiply or replace</param>
            public void BlackAndWhite(bool multiply = false) => JSRef!.CallVoid("blackAndWhite", multiply);
            /// <summary>
            /// Set the hue property of the color matrix.
            /// </summary>
            /// <param name="rotation">in degrees</param>
            /// <param name="multiply">whether to multiply or replace</param>
            public void Hue(float rotation, bool multiply = false) => JSRef!.CallVoid("hue", rotation, multiply);
            /// <summary>
            /// Set the contrast matrix, increase the separation between dark and bright
            /// </summary>
            /// <param name="amount">value of the contrast (0-1)</param>
            /// <param name="multiply">whether to multiply or replace</param>
            public void Contrast(float amount, bool multiply = false) => JSRef!.CallVoid("contrast", amount, multiply);
            /// <summary>
            /// Set the saturation matrix, increase the separation between colors
            /// </summary>
            /// <param name="amount">The saturation amount (0-1)</param>
            /// <param name="multiply">whether to multiply or replace</param>
            public void Saturate(float amount, bool multiply = false) => JSRef!.CallVoid("saturate", amount, multiply);
            /// <summary>
            /// Desaturate image (remove color)
            /// </summary>
            /// <param name="multiply">whether to multiply or replace</param>
            public void Desaturate(bool multiply = false) => JSRef!.CallVoid("desaturate", multiply);
            /// <summary>
            /// Negative image (inverse colors)
            /// </summary>
            /// <param name="multiply">whether to multiply or replace</param>
            public void Negative(bool multiply = false) => JSRef!.CallVoid("negative", multiply);
            /// <summary>
            /// Sepia image
            /// </summary>
            /// <param name="multiply">whether to multiply or replace</param>
            public void Sepia(bool multiply = false) => JSRef!.CallVoid("sepia", multiply);
            /// <summary>
            /// Color motion picture process invented in 1916 (classes over 2 colors)
            /// </summary>
            /// <param name="multiply">whether to multiply or replace</param>
            public void Technicolor(bool multiply = false) => JSRef!.CallVoid("technicolor", multiply);
            /// <summary>
            /// Polaroid camera effect
            /// </summary>
            /// <param name="multiply">whether to multiply or replace</param>
            public void Polaroid(bool multiply = false) => JSRef!.CallVoid("polaroid", multiply);
            /// <summary>
            /// Filter that transforms from RGB to BGR
            /// </summary>
            /// <param name="multiply">whether to multiply or replace</param>
            public void ToBGR(bool multiply = false) => JSRef!.CallVoid("toBGR", multiply);
            /// <summary>
            /// Color reversal film introduced by Eastman Kodak in 1935
            /// </summary>
            /// <param name="multiply">whether to multiply or replace</param>
            public void Kodachrome(bool multiply = false) => JSRef!.CallVoid("kodachrome", multiply);
            /// <summary>
            /// Browni camera effect
            /// </summary>
            /// <param name="multiply">whether to multiply or replace</param>
            public void Browni(bool multiply = false) => JSRef!.CallVoid("browni", multiply);
            /// <summary>
            /// Vintage camera effect
            /// </summary>
            /// <param name="multiply">whether to multiply or replace</param>
            public void Vintage(bool multiply = false) => JSRef!.CallVoid("vintage", multiply);
            /// <summary>
            /// We don't know exactly what it does, kind of gradient map, but funny to use!
            /// </summary>
            /// <param name="desaturation">The desaturation amount</param>
            /// <param name="toned">The toned amount</param>
            /// <param name="lightColor">The light color</param>
            /// <param name="darkColor">The dark color</param>
            /// <param name="multiply">whether to multiply or replace</param>
            public void ColorTone(float desaturation, float toned, float lightColor, float darkColor, bool multiply = false) => JSRef!.CallVoid("colorTone", desaturation, toned, lightColor, darkColor, multiply);
            /// <summary>
            /// Night effect
            /// </summary>
            /// <param name="intensity">The intensity of the night effect</param>
            /// <param name="multiply">whether to multiply or replace</param>
            public void Night(float intensity, bool multiply = false) => JSRef!.CallVoid("night", intensity, multiply);
            /// <summary>
            /// Predator effect
            /// </summary>
            /// <param name="amount">The amount of the predator effect</param>
            /// <param name="multiply">whether to multiply or replace</param>
            public void Predator(float amount, bool multiply = false) => JSRef!.CallVoid("predator", amount, multiply);
            /// <summary>
            /// LSD effect
            /// </summary>
            /// <param name="multiply">whether to multiply or replace</param>
            public void Lsd(bool multiply = false) => JSRef!.CallVoid("lsd", multiply);
            /// <summary>
            /// Erase the current matrix
            /// </summary>
            public void Reset() => JSRef!.CallVoid("reset");
        }
    }
}
