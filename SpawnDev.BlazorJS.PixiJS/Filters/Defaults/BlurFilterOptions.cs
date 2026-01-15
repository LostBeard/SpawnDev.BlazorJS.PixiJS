using SpawnDev.BlazorJS.JSObjects;
using Microsoft.JSInterop;

namespace SpawnDev.BlazorJS.PixiJS
{
    public static partial class PIXI
    {
        /// <summary>
        /// Options for the BlurFilter constructor.
        /// </summary>
        public class BlurFilterOptions : JSObject
        {
            /// <summary>
            /// Deserialization constructor
            /// </summary>
            public BlurFilterOptions(IJSInProcessObjectReference _ref) : base(_ref) { }
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public BlurFilterOptions() : base(JS.New("Object")) { }

            /// <summary>
            /// The strength of the blur properties.
            /// </summary>
            public float? Strength { get => JSRef!.Get<float?>("strength"); set => JSRef!.Set("strength", value); }
            
            /// <summary>
            /// The quality of the blur properties.
            /// </summary>
            public int? Quality { get => JSRef!.Get<int?>("quality"); set => JSRef!.Set("quality", value); }
            
            /// <summary>
            /// The resolution of the blur properties.
            /// </summary>
            public int? Resolution { get => JSRef!.Get<int?>("resolution"); set => JSRef!.Set("resolution", value); }
            
            /// <summary>
            /// The kernelSize of the blur properties.
            /// </summary>
            public int? KernelSize { get => JSRef!.Get<int?>("kernelSize"); set => JSRef!.Set("kernelSize", value); }
        }
    }
}
