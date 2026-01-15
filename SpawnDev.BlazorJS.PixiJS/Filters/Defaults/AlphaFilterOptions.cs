using Microsoft.JSInterop;

namespace SpawnDev.BlazorJS.PixiJS
{
    public static partial class PIXI
    {
        /// <summary>
        /// Options for the AlphaFilter constructor.
        /// </summary>
        public class AlphaFilterOptions : JSObject
        {
            /// <summary>
            /// Deserialization constructor
            /// </summary>
            public AlphaFilterOptions(IJSInProcessObjectReference _ref) : base(_ref) { }

            /// <summary>
            /// Creates a new instance
            /// </summary>
            public AlphaFilterOptions() : base(JS.New("Object")) { }

            /// <summary>
            /// The alpha value to use.
            /// </summary>
            public float? Alpha { get => JSRef!.Get<float?>("alpha"); set => JSRef!.Set("alpha", value); }
        }
    }
}
