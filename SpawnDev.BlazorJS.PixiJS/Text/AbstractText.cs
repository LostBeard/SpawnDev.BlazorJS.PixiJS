using Microsoft.JSInterop;

namespace SpawnDev.BlazorJS.PixiJS
{
    public static partial class PIXI
    {
        /// <summary>
        /// https://pixijs.download/release/docs/scene.AbstractText.html
        /// </summary>
        public class AbstractText : ViewContainer
        {
            /// <inheritdoc/>
            public AbstractText(IJSInProcessObjectReference _ref) : base(_ref) { }
            /// <summary>
            /// The anchor sets the origin point of the text. The default is (0,0), this means the text's origin is the top left.
            /// </summary>
            public ObservablePoint Anchor { get => JSRef!.Get<ObservablePoint>("anchor"); set => JSRef!.Set("anchor", value); }
        }
    }
}
