using Microsoft.JSInterop;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.PixiJS
{
    public static partial class PIXI
    {
        /// <summary>
        /// EventEmitter is a base class for many PixiJS objects that handle events.<br/>
        /// It is based on eventemitter3.<br/>
        /// https://github.com/primus/eventemitter3
        /// </summary>
        public class EventEmitter : JSObject
        {
            /// <summary>
            /// Deserialization constructor
            /// </summary>
            /// <param name="_ref"></param>
            public EventEmitter(IJSInProcessObjectReference _ref) : base(_ref) { }

            #region Methods
            /// <summary>
            /// Adds a listener for a given event.
            /// </summary>
            /// <param name="eventName"></param>
            /// <param name="callback"></param>
            public void On(string eventName, Callback callback) => JSRef!.CallVoid("on", eventName, callback);
            /// <summary>
            /// Adds a one-time listener for a given event.
            /// </summary>
            /// <param name="eventName"></param>
            /// <param name="callback"></param>
            public void Once(string eventName, Callback callback) => JSRef!.CallVoid("once", eventName, callback);
            /// <summary>
            /// Removes the specified listener from the listener array for the event named eventName.
            /// </summary>
            /// <param name="eventName"></param>
            /// <param name="callback"></param>
            public void Off(string eventName, Callback callback) => JSRef!.CallVoid("off", eventName, callback);
            /// <summary>
            /// Calls each of the listeners registered for a given event.
            /// </summary>
            /// <param name="eventName"></param>
            /// <param name="args"></param>
            /// <returns></returns>
            public bool Emit(string eventName, params object[] args)
            {
                var finalArgs = new object[args.Length + 1];
                finalArgs[0] = eventName;
                System.Array.Copy(args, 0, finalArgs, 1, args.Length);
                return JSRef!.CallApply<bool>("emit", finalArgs);
            }
            /// <summary>
            /// Removes the specified listener from the listener array for the event named eventName.
            /// </summary>
            /// <param name="eventName"></param>
            /// <param name="callback"></param>
            public void RemoveListener(string eventName, Callback callback) => JSRef!.CallVoid("removeListener", eventName, callback);
            /// <summary>
            /// Removes all listeners, or those of the specified eventName.
            /// </summary>
            /// <param name="eventName"></param>
            public void RemoveAllListeners(string? eventName = null) => JSRef!.CallVoid("removeAllListeners", eventName);
            #endregion

            #region Action Overloads
            // Support for Action and Action<T> with automatic Callback reference counting
            // This allows direct use of Action without ActionEvent if desired
            private static Dictionary<object, CallBackInfo> CallBackInfos { get; } = new Dictionary<object, CallBackInfo>();

            /// <summary>
            /// Adds a listener for a given event.
            /// </summary>
            public void On(string eventName, Action listener)
            {
                if (!CallBackInfos.TryGetValue(listener, out CallBackInfo? info))
                {
                    info = new CallBackInfo { Callback = Callback.Create(listener) };
                    CallBackInfos[listener] = info;
                }
                info.RefCount++;
                On(eventName, info.Callback);
            }
            /// <summary>
            /// Adds a listener for a given event.
            /// </summary>
            public void On<T1>(string eventName, Action<T1> listener)
            {
                if (!CallBackInfos.TryGetValue(listener, out CallBackInfo? info))
                {
                    info = new CallBackInfo { Callback = Callback.Create(listener) };
                    CallBackInfos[listener] = info;
                }
                info.RefCount++;
                On(eventName, info.Callback);
            }
            /// <summary>
            /// Removes the specified listener for the event.
            /// </summary>
            public void Off(string eventName, Action listener)
            {
                if (!CallBackInfos.TryGetValue(listener, out CallBackInfo? info)) return;
                info.RefCount--;
                Off(eventName, info.Callback);
                if (info.RefCount <= 0)
                {
                    CallBackInfos.Remove(listener);
                    info.Callback.Dispose();
                }
            }
            /// <summary>
            /// Removes the specified listener for the event.
            /// </summary>
            public void Off<T1>(string eventName, Action<T1> listener)
            {
                if (!CallBackInfos.TryGetValue(listener, out CallBackInfo? info)) return;
                info.RefCount--;
                Off(eventName, info.Callback);
                if (info.RefCount <= 0)
                {
                    CallBackInfos.Remove(listener);
                    info.Callback.Dispose();
                }
            }
            #endregion

            private class CallBackInfo
            {
                public Callback Callback { get; set; } = default!;
                public int RefCount { get; set; }
            }
        }
    }
}
