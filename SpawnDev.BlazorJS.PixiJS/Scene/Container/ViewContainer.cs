using Microsoft.JSInterop;

namespace SpawnDev.BlazorJS.PixiJS
{
    public static partial class PIXI
    {
        /// <summary>
        /// A ViewContainer is a type of container that represents a view. This view can be a Sprite, a Graphics object, or any other object that can be rendered. This class is abstract and should not be used directly.<br/>
        /// https://pixijs.download/v8.7.1/docs/scene.ViewContainer.html
        /// </summary>
        public class ViewContainer : Container, IView
        {
            /// <inheritdoc/>
            public ViewContainer(IJSInProcessObjectReference _ref) : base(_ref) { }
            /// <inheritdoc/>
            public long Uid => JSRef!.Get<long>("uid");
            /// <inheritdoc/>
            public bool Batched { get => JSRef!.Get<bool>("batched"); set => JSRef!.Set("batched", value); }
            /// <inheritdoc/>
            public string RenderPipeId => JSRef!.Get<string>("renderPipeId");
            /// <inheritdoc/>
            public bool RoundPixels { get => JSRef!.Get<bool>("roundPixels"); set => JSRef!.Set("roundPixels", value); }
            /// <inheritdoc/>
            public BoundsData Bounds { get => JSRef!.Get<BoundsData>("bounds"); set => JSRef!.Set("bounds", value); }
            /// <inheritdoc/>
            public bool ContainsPoint(Point point) => JSRef!.Call<bool>("containsPoint");
        }
    }
}
