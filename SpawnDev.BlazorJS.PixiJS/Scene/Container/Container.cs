using Microsoft.JSInterop;

namespace SpawnDev.BlazorJS.PixiJS
{
    public static partial class PIXI
    {
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
