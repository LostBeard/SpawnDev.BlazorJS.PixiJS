using Microsoft.JSInterop;

namespace SpawnDev.BlazorJS.PixiJS
{
    public static partial class PIXI
    {
        /// <summary>
        /// Options for the TilingSprite constructor.
        /// </summary>
        public class TilingSpriteOptions : JSObject
        {
            /// <summary>
            /// Deserialization constructor
            /// </summary>
            public TilingSpriteOptions(IJSInProcessObjectReference _ref) : base(_ref) { }

            /// <summary>
            /// Creates a new instance
            /// </summary>
            public TilingSpriteOptions() : base(JS.New("Object")) { }

            /// <summary>
            /// The texture of the tiling sprite.
            /// </summary>
            public Texture Texture { get => JSRef!.Get<Texture>("texture"); set => JSRef!.Set("texture", value); }

            /// <summary>
            /// The width of the tiling sprite.
            /// </summary>
            public float? Width { get => JSRef!.Get<float?>("width"); set => JSRef!.Set("width", value); }

            /// <summary>
            /// The height of the tiling sprite.
            /// </summary>
            public float? Height { get => JSRef!.Get<float?>("height"); set => JSRef!.Set("height", value); }
        }
    }
}
