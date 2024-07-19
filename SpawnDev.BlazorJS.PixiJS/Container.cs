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
        public class ObservablePoint : PointLike
        {

            #region Constructors
            /// <summary>
            /// Deserialization constructor
            /// </summary>
            /// <param name="_ref"></param>
            public ObservablePoint(IJSInProcessObjectReference _ref) : base(_ref) { }
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public ObservablePoint() : base(JS.New("PIXI.ObservablePoint")) { }
            #endregion
        }
        public class Container : JSObject
        {
            #region Constructors
            /// <summary>
            /// Deserialization constructor
            /// </summary>
            /// <param name="_ref"></param>
            public Container(IJSInProcessObjectReference _ref) : base(_ref) { }
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public Container() : base(JS.New("PIXI.Container")) { }
            #endregion
            #region Properties
            public float X { get => JSRef!.Get<float>("x"); set => JSRef!.Set("x", value); }
            public float Y { get => JSRef!.Get<float>("y"); set => JSRef!.Set("y", value); }
            public float Width { get => JSRef!.Get<float>("width"); set => JSRef!.Set("width", value); }
            public float Height { get => JSRef!.Get<float>("height"); set => JSRef!.Set("height", value); }

            public float Rotation { get => JSRef!.Get<float>("rotation"); set => JSRef!.Set("rotation", value); }


            public ObservablePoint Pivot { get => JSRef!.Get<ObservablePoint>("pivot"); set => JSRef!.Set("pivot", value); }

            #endregion
            #region Methods
            /// <summary>
            /// Adds one or more children to the container.
            /// </summary>
            public void AddChild(params object[] children) => JSRef!.CallApplyVoid("addChild", children);
            #endregion
            #region Events

            #endregion
        }
    }
}
