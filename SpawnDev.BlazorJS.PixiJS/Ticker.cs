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
            /// <summary>
            /// Register a handler for tick events. Calls continuously unless it is removed or the ticker is stopped.
            /// </summary>
            /// <param name="actionCallback"></param>
            public Ticker Add(ActionCallback<Ticker> actionCallback)
            {
                JSRef!.CallVoid("add", actionCallback);
                return this;
            }
            /// <summary>
            /// Removes any handlers matching the function and context parameters. If no handlers are left after removing, then it cancels the animation frame.
            /// </summary>
            /// <param name="actionCallback"></param>
            /// <returns></returns>
            public Ticker Remove(ActionCallback<Ticker> actionCallback)
            {
                JSRef!.CallVoid("remove", actionCallback);
                return this;
            }
            /// <summary>
            /// Register a handler for tick events. Calls continuously unless it is removed or the ticker is stopped.
            /// </summary>
            /// <param name="actionCallback"></param>
            public Ticker Add(Action<Ticker> actionCallback)
            {
                JSRef!.CallVoid("add", Callback.RefAdd(actionCallback));
                return this;
            }
            /// <summary>
            /// Removes any handlers matching the function and context parameters. If no handlers are left after removing, then it cancels the animation frame.
            /// </summary>
            /// <param name="actionCallback"></param>
            /// <returns></returns>
            public Ticker Remove(Action<Ticker> actionCallback) {

                var cb = Callback.RefGet(actionCallback, false);
                if (cb == null) return this;
                Remove(cb);
                Callback.RefDel(actionCallback);
                return this;
            }
            #endregion
            #region Events
            /// <summary>
            /// Register or unregister a handler for tick events. Registered handlers are called continuously unless removed or the ticker is stopped.
            /// </summary>
            public JSEventCallback<Ticker> OnTick { get => new JSEventCallback<Ticker>(o => Add((ActionCallback<Ticker>)o), o => Remove((ActionCallback<Ticker>)o)); set { } }
            #endregion
        }
    }
}
