using Microsoft.JSInterop;

namespace SpawnDev.BlazorJS.PixiJS
{
    public static partial class PIXI
    {
        /// <summary>
        /// Common interface for points. Both Point and ObservablePoint implement it<br/>
        /// https://pixijs.download/release/docs/maths.PointLike.html
        /// </summary>
        public class PointLike : PointData, IPointLike
        {
            /// <inheritdoc/>
            public PointLike(IJSInProcessObjectReference _ref) : base(_ref) { }
            /// <inheritdoc/>
            public void Set(float x, float y) => JSRef!.CallVoid("set", x, y);
            /// <inheritdoc/>
            public void Set(float xy) => JSRef!.CallVoid("set", xy);
            /// <inheritdoc/>
            public void Set() => JSRef!.CallVoid("set");
            /// <inheritdoc/>
            public bool Equals(IPointData p) => JSRef!.Call<bool>("equals", p);
            /// <inheritdoc/>
            public TPointLike CopyFrom<TPointLike>(IPointLike p) where TPointLike : IPointLike => JSRef!.Call<TPointLike>("copyFrom", p);
            /// <inheritdoc/>
            public void CopyFrom(IPointLike p) => JSRef!.CallVoid("copyFrom", p);
            /// <inheritdoc/>
            public TPointLike CopyTo<TPointLike>(TPointLike p) where TPointLike : IPointLike => JSRef!.Call<TPointLike>("copyTo", p);
            /// <inheritdoc/>
            public void CopyTo(IPointLike p) => JSRef!.CallVoid("copyTo", p);
        }
    }
}
