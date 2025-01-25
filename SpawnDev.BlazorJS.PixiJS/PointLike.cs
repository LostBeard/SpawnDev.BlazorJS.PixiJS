using Microsoft.JSInterop;

namespace SpawnDev.BlazorJS.PixiJS
{
    public static partial class PIXI
    {
        public class PointLike : JSObject, PointData
        {
            #region Constructors
            /// <summary>
            /// Deserialization constructor
            /// </summary>
            /// <param name="_ref"></param>
            public PointLike(IJSInProcessObjectReference _ref) : base(_ref) { }
            #endregion
            /// <summary>
            /// X coord
            /// </summary>
            public float X { get => JSRef!.Get<float>("x"); set => JSRef!.Set("x", value); }
            /// <summary>
            /// Y coord
            /// </summary>
            public float Y { get => JSRef!.Get<float>("y"); set => JSRef!.Set("y", value); }
            public void Set(float x, float y) => JSRef!.CallVoid("set", x, y);
            public void Set(float xy) => JSRef!.CallVoid("set", xy);
            public bool Equals(PointData p) => JSRef!.Call<bool>("equals", p);
            public virtual void CopyTo(PointLike p)
            {
                JSRef!.CallVoid("copyTo", p);
            }
            public virtual void CopyFrom(PointData p)
            {
                JSRef!.CallVoid("copyFrom", p);
            }
        }
    }
}
