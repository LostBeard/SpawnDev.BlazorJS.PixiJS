using Microsoft.JSInterop;

namespace SpawnDev.BlazorJS.PixiJS
{
    public static partial class PIXI
    {
        /// <summary>
        /// A Noise effect filter.<br/>
        /// https://pixijs.download/v8.14.3/docs/filters.NoiseFilter.html
        /// </summary>
        public class NoiseFilter : Filter
        {
            /// <summary>
            /// Deserialization constructor
            /// </summary>
            public NoiseFilter(IJSInProcessObjectReference _ref) : base(_ref) { }

            /// <summary>
            /// Creates a new NoiseFilter instance.
            /// </summary>
            /// <param name="options">Options for the NoiseFilter</param>
            public NoiseFilter(NoiseFilterOptions options) : base(JS.New("PIXI.NoiseFilter", options)) { }

            /// <summary>
            /// Creates a new NoiseFilter instance.
            /// </summary>
            /// <param name="noise">The amount of noise to apply.</param>
            /// <param name="seed">A seed value to apply to the random noise generation. </param>
            public NoiseFilter(float noise = 0.5f, int seed = 0) : this(new NoiseFilterOptions { Noise = noise, Seed = seed }) { }

            /// <summary>
            /// The amount of noise to apply.
            /// </summary>
            public float Noise { get => JSRef!.Get<float>("noise"); set => JSRef!.Set("noise", value); }

            /// <summary>
            /// A seed value to apply to the random noise generation.
            /// </summary>
            public float Seed { get => JSRef!.Get<float>("seed"); set => JSRef!.Set("seed", value); }
        }
    }
}
