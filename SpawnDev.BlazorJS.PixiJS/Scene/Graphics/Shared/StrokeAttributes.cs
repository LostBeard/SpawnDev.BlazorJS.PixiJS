namespace SpawnDev.BlazorJS.PixiJS
{
    public static partial class PIXI
    {
        /// <summary>
        /// A stroke attribute object, used to define properties for a stroke.
        /// </summary>
        public interface StrokeAttributes
        {
            /// <summary>
            /// The width of the stroke. 
            /// </summary>
            float? Width { get; set; }
            /// <summary>
            /// The alignment of the stroke.
            /// </summary>
            float? Alignment { get; set; }
            /// <summary>
            /// The line cap style to use.<br/>
            /// 'butt' | 'round' | 'square'
            /// </summary>
            string? Cap { get; set; }
            /// <summary>
            /// The line join style to use.<br/>
            /// 'round' | 'bevel' | 'miter'
            /// </summary>
            string? Join { get; set; }
            /// <summary>
            /// The miter limit to use.
            /// </summary>
            float? MiterLimit { get; set; }
            /// <summary>
            /// If the stroke is a pixel line. NOTE: this is only available for Graphic fills
            /// </summary>
            bool? PixelLine { get; set; }
        }
    }
}
