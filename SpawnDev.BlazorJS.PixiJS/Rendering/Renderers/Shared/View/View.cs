using Microsoft.JSInterop;

namespace SpawnDev.BlazorJS.PixiJS
{
    public static partial class PIXI
    {
        /// <summary>
        /// A view is something that is able to be rendered by the renderer.
        /// </summary>
        public class View : JSObject, IView
        {
            /// <inheritdoc/>
            public View(IJSInProcessObjectReference _ref) : base(_ref) { }
            /// <inheritdoc/>
            public long Uid => JSRef!.Get<long>("uid");
            /// <inheritdoc/>
            public bool Batched { get => JSRef!.Get<bool>("batched"); set => JSRef!.Set("batched", value); }
            /// <inheritdoc/>
            public string RenderPipeId => JSRef!.Get<string>("renderPipeId");
            /// <inheritdoc/>
            public bool RoundPixels { get => JSRef!.Get<bool>("roundPixels"); set => JSRef!.Set("roundPixels", value); }
            /// <inheritdoc/>
            /// <inheritdoc/>
            public BoundsData? Bounds { get => JSRef!.Get<BoundsData?>("bounds"); set => JSRef!.Set("bounds", value); }
            /// <inheritdoc/>
            public bool ContainsPoint(Point point) => JSRef!.Call<bool>("containsPoint");
        }
    }
}
