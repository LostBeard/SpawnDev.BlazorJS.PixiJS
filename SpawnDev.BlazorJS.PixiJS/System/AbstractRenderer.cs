using Microsoft.JSInterop;

namespace SpawnDev.BlazorJS.PixiJS
{
    public static partial class PIXI
    {
        /// <summary>
        /// The AbstractRenderer is the base for a PixiJS Renderer. It is developed using the WebGL API.
        /// https://pixijs.download/release/docs/rendering.AbstractRenderer.html
        /// </summary>
        public class AbstractRenderer : JSObject
        {
            #region Constructors
            /// <summary>
            /// Deserialization constructor
            /// </summary>
            /// <param name="_ref"></param>
            public AbstractRenderer(IJSInProcessObjectReference _ref) : base(_ref) { }
            #endregion
            #region Properties

            /// <summary>
            /// The EventSystem instance.
            /// </summary>
            public EventSystem Events => JSRef!.Get<EventSystem>("events");
            #endregion
            #region Methods
            /// <summary>
            /// Renders the object to its view.
            /// </summary>
            /// <param name="container">The container to render.</param>
            /// <param name="options">Object containing render options.</param>
            public void Render(Container container, RenderOptions options) => JSRef!.CallVoid("render", container, options);
            #endregion
            #region Events

            #endregion
        }
    }
}
