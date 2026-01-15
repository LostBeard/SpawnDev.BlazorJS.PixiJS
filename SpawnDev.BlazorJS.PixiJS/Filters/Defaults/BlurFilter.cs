using Microsoft.JSInterop;

namespace SpawnDev.BlazorJS.PixiJS
{
    public static partial class PIXI
    {
        /// <summary>
        /// The BlurFilter applies a Gaussian blur to an object.<br/>
        /// https://pixijs.download/v8.14.3/docs/filters.BlurFilter.html
        /// </summary>
        public class BlurFilter : Filter
        {
            /// <summary>
            /// Deserialization constructor
            /// </summary>
            public BlurFilter(IJSInProcessObjectReference _ref) : base(_ref) { }

            /// <summary>
            /// Creates a new BlurFilter instance.
            /// </summary>
            /// <param name="options">Options for the BlurFilter</param>
            public BlurFilter(BlurFilterOptions options) : base(JS.New("PIXI.BlurFilter", options)) { }

            /// <summary>
            /// Creates a new BlurFilter instance.
            /// </summary>
            /// <param name="strength">The strength of the blur properties.</param>
            /// <param name="quality">The quality of the blur properties.</param>
            /// <param name="resolution">The resolution of the blur properties.</param>
            /// <param name="kernelSize">The kernelSize of the blur properties.</param>
            public BlurFilter(float strength = 8, int quality = 4, int? resolution = null, int? kernelSize = null)
                : this(CreateOptions(strength, quality, resolution, kernelSize)) { }

            private static BlurFilterOptions CreateOptions(float strength, int quality, int? resolution, int? kernelSize)
            {
                var options = new BlurFilterOptions();
                options.Strength = strength;
                options.Quality = quality;
                if (resolution.HasValue) options.Resolution = resolution;
                if (kernelSize.HasValue) options.KernelSize = kernelSize;
                return options;
            }

            public float Blur { get => JSRef!.Get<float>("blur"); set => JSRef!.Set("blur", value); }
            public float BlurX { get => JSRef!.Get<float>("blurX"); set => JSRef!.Set("blurX", value); }
            public float BlurY { get => JSRef!.Get<float>("blurY"); set => JSRef!.Set("blurY", value); }
            public int Quality { get => JSRef!.Get<int>("quality"); set => JSRef!.Set("quality", value); }
            public bool RepeatEdgePixels { get => JSRef!.Get<bool>("repeatEdgePixels"); set => JSRef!.Set("repeatEdgePixels", value); }
        }
    }
}
