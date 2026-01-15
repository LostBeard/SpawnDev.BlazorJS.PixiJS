using Microsoft.JSInterop;

namespace SpawnDev.BlazorJS.PixiJS
{
    public static partial class PIXI
    {
        public class RenderOptions : JSObject
        {
            public RenderOptions(IJSInProcessObjectReference _ref) : base(_ref) { }
            public RenderOptions() : base(JS.New("Object")) { }

            /// <summary>
            /// The render texture to render to.
            /// </summary>
            public RenderTexture? RenderTexture { get => JSRef!.Get<RenderTexture?>("renderTexture"); set => JSRef!.Set("renderTexture", value); }

            /// <summary>
            /// Whether to clear the screen before rendering.
            /// </summary>
            public bool? Clear { get => JSRef!.Get<bool?>("clear"); set => JSRef!.Set("clear", value); }

            /// <summary>
            /// The transform to apply to the render.
            /// </summary>
            public Matrix? Transform { get => JSRef!.Get<Matrix?>("transform"); set => JSRef!.Set("transform", value); }

            /// <summary>
            /// Skip the update transform check.
            /// </summary>
            public bool? SkipUpdateTransform { get => JSRef!.Get<bool?>("skipUpdateTransform"); set => JSRef!.Set("skipUpdateTransform", value); }
        }
    }
}
