using SpawnDev.BlazorJS.JSObjects;
using Microsoft.JSInterop;

namespace SpawnDev.BlazorJS.PixiJS
{
    public static partial class PIXI
    {
        /// <summary>
        /// Options for the NoiseFilter constructor.
        /// </summary>
        public class NoiseFilterOptions : JSObject
        {
            /// <summary>
            /// Deserialization constructor
            /// </summary>
            public NoiseFilterOptions(IJSInProcessObjectReference _ref) : base(_ref) { }
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public NoiseFilterOptions() : base(JS.New("Object")) { }

            /// <summary>
            /// The amount of noise to apply.
            /// </summary>
            public float? Noise { get => JSRef!.Get<float?>("noise"); set => JSRef!.Set("noise", value); }
            
            /// <summary>
            /// A seed value to apply to the random noise generation.
            /// </summary>
            public float? Seed { get => JSRef!.Get<float?>("seed"); set => JSRef!.Set("seed", value); }
        }
    }
}
