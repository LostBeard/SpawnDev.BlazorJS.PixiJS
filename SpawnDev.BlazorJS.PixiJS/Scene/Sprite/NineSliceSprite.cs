using Microsoft.JSInterop;

namespace SpawnDev.BlazorJS.PixiJS
{
    public static partial class PIXI
    {
        /// <summary>
        /// The NineSliceSprite allows you to stretch a texture using 9-slice scaling.<br/>
        /// https://pixijs.download/v8.14.3/docs/scene.NineSliceSprite.html
        /// </summary>
        public class NineSliceSprite : Sprite
        {
            /// <summary>
            /// Deserialization constructor
            /// </summary>
            public NineSliceSprite(IJSInProcessObjectReference _ref) : base(_ref) { }
            
            /// <summary>
            /// Creates a new NineSliceSprite instance.
            /// </summary>
            /// <param name="texture">The texture to use.</param>
            public NineSliceSprite(Texture texture) : base(JS.New("PIXI.NineSliceSprite", texture)) { }
            
            /// <summary>
            /// Creates a new NineSliceSprite instance.
            /// </summary>
            /// <param name="texture">The texture to use.</param>
            /// <param name="leftWidth">The width of the left column.</param>
            /// <param name="topHeight">The height of the top row.</param>
            /// <param name="rightWidth">The width of the right column.</param>
            /// <param name="bottomHeight">The height of the bottom row.</param>
            public NineSliceSprite(Texture texture, float leftWidth, float topHeight, float rightWidth, float bottomHeight) 
                : this(new NineSliceSpriteOptions { Texture = texture, LeftWidth = leftWidth, TopHeight = topHeight, RightWidth = rightWidth, BottomHeight = bottomHeight }) { }
            /// <summary>
            /// The width of the left column.
            /// </summary>
            public float LeftWidth { get => JSRef!.Get<float>("leftWidth"); set => JSRef!.Set("leftWidth", value); }
            
            /// <summary>
            /// The width of the right column.
            /// </summary>
            public float RightWidth { get => JSRef!.Get<float>("rightWidth"); set => JSRef!.Set("rightWidth", value); }
            
            /// <summary>
            /// The height of the top row.
            /// </summary>
            public float TopHeight { get => JSRef!.Get<float>("topHeight"); set => JSRef!.Set("topHeight", value); }
            
            /// <summary>
            /// The height of the bottom row.
            /// </summary>
            public float BottomHeight { get => JSRef!.Get<float>("bottomHeight"); set => JSRef!.Set("bottomHeight", value); }
            
            /// <summary>
            /// Deserialization constructor used by Options constructor
            /// </summary>
            /// <param name="options">Options for the NineSliceSprite</param>
            public NineSliceSprite(NineSliceSpriteOptions options) : base(JS.New("PIXI.NineSliceSprite", options)) { }
        }
    }
}
