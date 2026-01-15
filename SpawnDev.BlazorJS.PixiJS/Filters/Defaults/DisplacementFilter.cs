using Microsoft.JSInterop;

namespace SpawnDev.BlazorJS.PixiJS
{
    public static partial class PIXI
    {
        /// <summary>
        /// The DisplacementFilter class uses the pixel values from the specified texture (called the displacement map) to perform a displacement of an object.<br/>
        /// https://pixijs.download/v8.14.3/docs/filters.DisplacementFilter.html
        /// </summary>
        public class DisplacementFilter : Filter
        {
            /// <summary>
            /// Deserialization constructor
            /// </summary>
            public DisplacementFilter(IJSInProcessObjectReference _ref) : base(_ref) { }
            
            /// <summary>
            /// Creates a new DisplacementFilter instance.
            /// </summary>
            /// <param name="options">Options for the DisplacementFilter</param>
            public DisplacementFilter(DisplacementFilterOptions options) : base(JS.New("PIXI.DisplacementFilter", options)) { }
            
            /// <summary>
            /// Creates a new DisplacementFilter instance.
            /// </summary>
            /// <param name="sprite">The sprite used for the displacement map.</param>
            /// <param name="scale">The scale of the displacement.</param>
            public DisplacementFilter(Sprite sprite, float scale = 20) : this(new DisplacementFilterOptions { Sprite = sprite, Scale = scale }) { }
            
            /// <summary>
            /// The scale to use for the displacement.
            /// </summary>
            public Point Scale { get => JSRef!.Get<Point>("scale"); set => JSRef!.Set("scale", value); }
        }
    }
}
