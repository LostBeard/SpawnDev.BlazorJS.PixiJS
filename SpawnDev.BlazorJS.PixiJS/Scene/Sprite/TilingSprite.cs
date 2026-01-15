using Microsoft.JSInterop;

namespace SpawnDev.BlazorJS.PixiJS
{
    public static partial class PIXI
    {
        /// <summary>
        /// A tiling sprite is a fast way of rendering a tiling image.<br/>
        /// https://pixijs.download/v8.14.3/docs/scene.TilingSprite.html
        /// </summary>
        public class TilingSprite : Sprite
        {
            /// <summary>
            /// Deserialization constructor
            /// </summary>
            public TilingSprite(IJSInProcessObjectReference _ref) : base(_ref) { }

            /// <summary>
            /// Creates a new TilingSprite instance.
            /// </summary>
            /// <param name="options">Options for the TilingSprite</param>
            public TilingSprite(TilingSpriteOptions options) : base(JS.New("PIXI.TilingSprite", options)) { }

            /// <summary>
            /// Creates a new TilingSprite instance.
            /// </summary>
            /// <param name="texture">The texture of the tiling sprite.</param>
            /// <param name="width">The width of the tiling sprite.</param>
            /// <param name="height">The height of the tiling sprite.</param>
            public TilingSprite(Texture texture, float width = 100, float height = 100) : this(new TilingSpriteOptions { Texture = texture, Width = width, Height = height }) { }

            /// <summary>
            /// The offset of the image that is being tiled
            /// </summary>
            public ObservablePoint TilePosition => JSRef!.Get<ObservablePoint>("tilePosition");

            /// <summary>
            /// The scaling of the image that is being tiled
            /// </summary>
            public ObservablePoint TileScale => JSRef!.Get<ObservablePoint>("tileScale");

            /// <summary>
            /// Changes the margin used for clamping the texture coords.
            /// </summary>
            /// <param name="margin"></param>
            public void ClampMargin(float margin) => JSRef!.CallVoid("clampMargin", margin);
        }
    }
}
