using Microsoft.JSInterop;

namespace SpawnDev.BlazorJS.PixiJS
{
    public static partial class PIXI
    {
        /// <summary>
        /// Options for the DisplacementFilter constructor.
        /// </summary>
        public class DisplacementFilterOptions : JSObject
        {
            /// <summary>
            /// Deserialization constructor
            /// </summary>
            public DisplacementFilterOptions(IJSInProcessObjectReference _ref) : base(_ref) { }

            /// <summary>
            /// Creates a new instance
            /// </summary>
            public DisplacementFilterOptions() : base(JS.New("Object")) { }

            /// <summary>
            /// The sprite used for the displacement map.
            /// </summary>
            public Sprite Sprite { get => JSRef!.Get<Sprite>("sprite"); set => JSRef!.Set("sprite", value); }

            /// <summary>
            /// The scale of the displacement.
            /// </summary>
            public float? Scale { get => JSRef!.Get<float?>("scale"); set => JSRef!.Set("scale", value); }
        }
    }
}
