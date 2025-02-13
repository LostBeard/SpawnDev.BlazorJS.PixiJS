using Microsoft.JSInterop;

namespace SpawnDev.BlazorJS.PixiJS
{
    public static partial class PIXI
    {
        /// <summary>
        /// Common interface for points. Both Point and ObservablePoint implement it<br/>
        /// https://pixijs.download/release/docs/maths.PointData.html
        /// </summary>
        public class PointData : JSObject, IPointData
        {
            /// <inheritdoc/>
            public PointData(IJSInProcessObjectReference _ref) : base(_ref) { }
            /// <inheritdoc/>
            public float X { get => JSRef!.Get<float>("x"); set => JSRef!.Set("x", value); }
            /// <inheritdoc/>
            public float Y { get => JSRef!.Get<float>("y"); set => JSRef!.Set("y", value); }
        }
    }
}
