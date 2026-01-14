using Microsoft.JSInterop;

namespace SpawnDev.BlazorJS.PixiJS
{
    public static partial class PIXI
    {
        /// <summary>
        /// A Ticker class that runs an update loop that other objects listen to.<br/>
        /// This class is composed around listeners meant for execution on the next requested animation frame. Animation frames are requested only when necessary, e.g.When the ticker is started and the emitter has listeners.<br/>
        /// https://pixijs.download/v4.3.1/docs/PIXI.ticker.Ticker.html
        /// </summary>
        public class Ticker : JSObject
        {
            #region Constructors
            /// <summary>
            /// Deserialization constructor
            /// </summary>
            /// <param name="_ref"></param>
            public Ticker(IJSInProcessObjectReference _ref) : base(_ref) { }
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public Ticker() : base(JS.New("PIXI.Ticker")) { }
            #endregion
            #region Properties
            /// <summary>
            /// Scalar time value from last frame to this frame.<br/>
            /// This value is capped by setting {@link ticker.Ticker#minFPS|minFPS}* and is scaled with {@link ticker.Ticker#speed|speed}.<br/>
            /// Note: The cap may be exceeded by scaling.
            /// </summary>
            public float DeltaTime => JSRef!.Get<float>("deltaTime");
            /// <summary>
            /// The frames per second at which this ticker is running. The default is approximately 60 in most modern browsers. *** Note:** This does not factor in the value of {@link ticker.Ticker#speed|speed}, which is specific to scaling { @link ticker.Ticker#deltaTime|deltaTime}.
            /// </summary>
            public float FPS => JSRef!.Get<float>("FPS");
            /// <summary>
            /// The number of listeners on this ticker, calculated by walking through linked list
            /// </summary>
            public int Count => JSRef!.Get<int>("count");
            /// <summary>
            /// Whether or not this ticker should invoke the method {@link ticker.Ticker#start|start} automatically when a listener is added.
            /// </summary>
            public bool AutoStart{ get => JSRef!.Get<bool>("autoStart"); set => JSRef!.Set("autoStart", value); }
            /// <summary>
            /// Scaler time elapsed in milliseconds from last frame to this frame. This value is capped by setting {@link ticker.Ticker#minFPS|minFPS} and is scaled with { @link ticker.Ticker#speed|speed}. *** Note:**The cap may be exceeded by scaling. If the platform supports DOMHighResTimeStamp, this value will have a precision of 1 µs.<br/> Defaults to target frame time<br/>@default 16.66
            /// </summary>
            public float DeltaMS { get => JSRef!.Get<float>("deltaMS"); set => JSRef!.Set("deltaMS", value); }
            /// <summary>
            /// Time elapsed in milliseconds from last frame to this frame. Opposed to what the scalar {@link ticker.Ticker#deltaTime|deltaTime} is based, this value is neither capped nor scaled. If the platform supports DOMHighResTimeStamp, this value will have a precision of 1 µs. Defaults to target frame time @default 16.66
            /// </summary>
            public float ElapsedMS { get => JSRef!.Get<float>("elapsedMS"); set => JSRef!.Set("elapsedMS", value); }
            /// <summary>
            /// The last time {@link ticker.Ticker#update|update} was invoked. This value is also reset internally outside of invoking update, but only when a new animation frame is requested. If the platform supports DOMHighResTimeStamp, this value will have a precision of 1 µs.
            /// </summary>
            public float LastTime { get => JSRef!.Get<float>("lastTime"); set => JSRef!.Set("lastTime", value); }
            /// <summary>
            /// Factor of current {@link ticker.Ticker#deltaTime|deltaTime}.<br/>
            /// @example<br/>
            /// Scales ticker.deltaTime to what would be the equivalent of approximately 120 FPS ticker.speed = 2;
            /// </summary>
            public float Speed { get => JSRef!.Get<float>("speed"); set => JSRef!.Set("speed", value); }
            /// <summary>
            /// Whether or not this ticker has been started. `true` if {@link ticker.Ticker#start|start} has been called. `false` if { @link ticker.Ticker#stop|Stop} has been called. While `false`, this value may change to `true` in the event of { @link ticker.Ticker#autoStart|autoStart} being `true` and a listener is added.
            /// </summary>
            public bool Started { get => JSRef!.Get<bool>("started"); set => JSRef!.Set("started", value); }
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
                JSRef!.CallVoid("add", CallbackRef.RefAdd(actionCallback));
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

                var cb = CallbackRef.RefGet(actionCallback, false);
                if (cb == null) return this;
                Remove(cb);
                CallbackRef.RefDel(actionCallback);
                return this;
            }
            static CallbackRef CallbackRef = new CallbackRef();
            #endregion
            #region Events
            /// <summary>
            /// Register or unregister a handler for tick events. Registered handlers are called continuously unless removed or the ticker is stopped.
            /// </summary>
            public ActionEvent<Ticker> OnTick { get => new ActionEvent<Ticker>(o => Add((ActionCallback<Ticker>)o), o => Remove((ActionCallback<Ticker>)o)); set { } }
            #endregion
        }
    }
}
