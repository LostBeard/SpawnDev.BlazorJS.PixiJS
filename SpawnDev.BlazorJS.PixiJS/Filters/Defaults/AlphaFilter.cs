using Microsoft.JSInterop;

namespace SpawnDev.BlazorJS.PixiJS
{
    public static partial class PIXI
    {
        /// <summary>
        /// Simplest filter - applies alpha.<br/>
        /// https://pixijs.download/v8.14.3/docs/filters.AlphaFilter.html
        /// </summary>
        public class AlphaFilter : Filter
        {
            /// <summary>
            /// Deserialization constructor
            /// </summary>
            public AlphaFilter(IJSInProcessObjectReference _ref) : base(_ref) { }

            /// <summary>
            /// Creates a new AlphaFilter instance.
            /// </summary>
            /// <param name="options">Options for the AlphaFilter</param>
            public AlphaFilter(AlphaFilterOptions options) : base(JS.New("PIXI.AlphaFilter", options)) { }

            /// <summary>
            /// Creates a new AlphaFilter instance.
            /// </summary>
            /// <param name="alpha">The alpha value to use.</param>
            public AlphaFilter(float alpha = 1.0f) : this(new AlphaFilterOptions { Alpha = alpha }) { }

            /// <summary>
            /// Coefficient for alpha multiplication
            /// </summary>
            public float Alpha { get => JSRef!.Get<float>("alpha"); set => JSRef!.Set("alpha", value); }
        }
    }
}
