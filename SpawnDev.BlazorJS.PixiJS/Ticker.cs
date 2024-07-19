using Microsoft.JSInterop;

namespace SpawnDev.BlazorJS.PixiJS
{
    public static partial class PIXI
    {
        /// <summary>
        /// A Ticker class that runs an update loop that other objects listen to.<br/>
        /// This class is composed around listeners meant for execution on the next requested animation frame. Animation frames are requested only when necessary, e.g.When the ticker is started and the emitter has listeners.<br/>
        /// </summary>
        public class Ticker : JSObject
        {
            #region Constructors
            /// <summary>
            /// Deserialization constructor
            /// </summary>
            /// <param name="_ref"></param>
            public Ticker(IJSInProcessObjectReference _ref) : base(_ref) { }
            #endregion
            #region Properties
            /// <summary>
            /// Scalar time value from last frame to this frame.<br/>
            /// This value is capped by setting {@link ticker.Ticker#minFPS|minFPS}* and is scaled with {@link ticker.Ticker#speed|speed}.<br/>
            /// Note: The cap may be exceeded by scaling.
            /// </summary>
            public float DeltaTime => JSRef!.Get<float>("deltaTime");
            #endregion
            #region Methods
            public void Add(ActionCallback<Ticker> actionCallback) => JSRef!.CallVoid("add", actionCallback);
            public void Remove(ActionCallback<Ticker> actionCallback) => JSRef!.CallVoid("remove", actionCallback);
            public void Add(Action<Ticker> actionCallback) => JSRef!.CallVoid("add", Callback.RefGet(actionCallback, true));
            public void Remove(Action<Ticker> actionCallback) => JSRef!.CallVoid("remove", Callback.RefGet(actionCallback, false));
            #endregion
            #region Events
            public JSEventCallback<Ticker> OnTick { get => new JSEventCallback<Ticker>(o => Add((ActionCallback<Ticker>)o), o => Remove((ActionCallback<Ticker>)o)); set { } }
            #endregion
        }
    }
}
