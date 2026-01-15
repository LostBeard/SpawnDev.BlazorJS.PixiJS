using SpawnDev.BlazorJS.JSObjects;
using Microsoft.JSInterop;

namespace SpawnDev.BlazorJS.PixiJS
{
    public static partial class PIXI
    {
        /// <summary>
        /// Options for the AnimatedSprite constructor.
        /// </summary>
        public class AnimatedSpriteOptions : JSObject
        {
            /// <summary>
            /// Deserialization constructor
            /// </summary>
            public AnimatedSpriteOptions(IJSInProcessObjectReference _ref) : base(_ref) { }
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public AnimatedSpriteOptions() : base(JS.New("Object")) { }

            /// <summary>
            /// An array of Texture objects that make up the animation.
            /// </summary>
            public Texture[] Textures { get => JSRef!.Get<Texture[]>("textures"); set => JSRef!.Set("textures", value); }
            
            /// <summary>
            /// Whether to use PIXI.Ticker.shared to auto update animation time.
            /// </summary>
            public bool? AutoUpdate { get => JSRef!.Get<bool?>("autoUpdate"); set => JSRef!.Set("autoUpdate", value); }
        }
    }
}
