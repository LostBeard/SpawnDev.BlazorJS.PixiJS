using SpawnDev.BlazorJS.JSObjects;
using Microsoft.JSInterop;

namespace SpawnDev.BlazorJS.PixiJS
{
    public static partial class PIXI
    {
        /// <summary>
        /// Options for the NineSliceSprite constructor.
        /// </summary>
        public class NineSliceSpriteOptions : JSObject
        {
            /// <summary>
            /// Deserialization constructor
            /// </summary>
            public NineSliceSpriteOptions(IJSInProcessObjectReference _ref) : base(_ref) { }
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public NineSliceSpriteOptions() : base(JS.New("Object")) { }

            /// <summary>
            /// The texture to use.
            /// </summary>
            public Texture Texture { get => JSRef!.Get<Texture>("texture"); set => JSRef!.Set("texture", value); }
            public float? LeftWidth { get => JSRef!.Get<float?>("leftWidth"); set => JSRef!.Set("leftWidth", value); }
            public float? TopHeight { get => JSRef!.Get<float?>("topHeight"); set => JSRef!.Set("topHeight", value); }
            public float? RightWidth { get => JSRef!.Get<float?>("rightWidth"); set => JSRef!.Set("rightWidth", value); }
            public float? BottomHeight { get => JSRef!.Get<float?>("bottomHeight"); set => JSRef!.Set("bottomHeight", value); }
        }
    }
}
