using Microsoft.JSInterop;

namespace SpawnDev.BlazorJS.PixiJS
{
    public static partial class PIXI
    {
        /// <summary>
        /// Component for masking.<br/>
        /// https://pixijs.download/v8.14.3/docs/scene.MaskData.html
        /// </summary>
        public class MaskData : JSObject
        {
            /// <summary>
            /// Deserialization constructor
            /// </summary>
            public MaskData(IJSInProcessObjectReference _ref) : base(_ref) { }
            
            /// <summary>
            /// Creates a new MaskData instance.
            /// </summary>
            /// <param name="maskObject">The object to use as the mask.</param>
            public MaskData(Container maskObject = null) : base(JS.New("PIXI.MaskData", maskObject)) { }

            /// <summary>
            /// The object that is being used as the mask.
            /// </summary>
            public Container MaskObject { get => JSRef!.Get<Container>("maskObject"); set => JSRef!.Set("maskObject", value); }

            /// <summary>
            /// Whether the mask is a sprite or a mesh.
            /// </summary>
            public bool Type { get => JSRef!.Get<bool>("type"); set => JSRef!.Set("type", value); }
            
        }
    }
}
