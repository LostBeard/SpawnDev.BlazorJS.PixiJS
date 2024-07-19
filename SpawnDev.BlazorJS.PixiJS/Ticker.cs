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
            /// Starts the ticker. If the ticker has listeners a new animation frame is requested at this point.
            /// </summary>
            public void Start() => JSRef!.CallVoid("start");
            /// <summary>
            /// Stops the ticker. If the ticker has requested an animation frame it is canceled at this point.
            /// </summary>
            public void Stop() => JSRef!.CallVoid("stop");
            /// <summary>
            /// Destroy the ticker and don't use after this. Calling this method removes all references to internal events.
            /// </summary>
            public void Destroy() => JSRef!.CallVoid("destroy");
            /// <summary>
            /// Triggers an update. An update entails setting the current {@link ticker.Ticker#elapsedMS|elapsedMS}, the current {@link ticker.Ticker#deltaTime|deltaTime}, invoking all listeners with current deltaTime,and then finally setting {@link ticker.Ticker#lastTime|lastTime} with the value of currentTime that was provided. This method will be called automatically by animation frame callbacks if the ticker instance has been started and listeners are added.
            /// </summary>
            public void Update() => JSRef!.CallVoid("update");
            /// <summary>
            /// Triggers an update. An update entails setting the current {@link ticker.Ticker#elapsedMS|elapsedMS}, the current {@link ticker.Ticker#deltaTime|deltaTime}, invoking all listeners with current deltaTime,and then finally setting {@link ticker.Ticker#lastTime|lastTime} with the value of currentTime that was provided. This method will be called automatically by animation frame callbacks if the ticker instance has been started and listeners are added.
            /// </summary>
            /// <param name="currentTime">The current time of execution.<br/>default performance.now()</param>
            public void Update(double currentTime) => JSRef!.CallVoid("update", currentTime);
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
            /// Register a handler for tick events. Calls continuously unless it is removed or the ticker is stopped.
            /// </summary>
            /// <param name="actionCallback"></param>
            public Ticker Add(Action<Ticker> actionCallback)
            {
                JSRef!.CallVoid("add", Callback.RefAdd(actionCallback));
                return this;
            }
            /// <summary>
            /// Add a handler for the tick event which is only execute once.
            /// </summary>
            /// <param name="actionCallback"></param>
            /// <returns></returns>
            public Ticker AddOnce(ActionCallback<Ticker> actionCallback)
            {
                JSRef!.CallVoid("addOnce", actionCallback);
                return this;
            }
            /// <summary>
            /// Add a handler for the tick event which is only execute once.
            /// </summary>
            /// <param name="actionCallback"></param>
            /// <returns></returns>
            public Ticker AddOnce(Action<Ticker> actionCallback)
            {
                JSRef!.CallVoid("addOnce", Callback.CreateOne(actionCallback));
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
