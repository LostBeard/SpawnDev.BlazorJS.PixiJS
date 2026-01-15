using Microsoft.JSInterop;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.PixiJS
{
    public static partial class PIXI
    {
        /// <summary>
        /// An event that is dispatched by the Federated Events API.<br/>
        /// https://pixijs.download/v8.14.3/docs/events.FederatedEvent.html
        /// </summary>
        public class FederatedEvent : JSObject
        {
            /// <summary>
            /// Deserialization constructor
            /// </summary>
            public FederatedEvent(IJSInProcessObjectReference _ref) : base(_ref) { }

            /// <summary>
            /// The propagation of the event will be stopped.
            /// </summary>
            public bool Bubbles => JSRef!.Get<bool>("bubbles");
            /// <summary>
            /// A boolean flag indicating if the event can be canceled.
            /// </summary>
            public bool Cancelable => JSRef!.Get<bool>("cancelable");
            /// <summary>
            /// A boolean flag indicating if the default action has been prevented.
            /// </summary>
            public bool DefaultPrevented => JSRef!.Get<bool>("defaultPrevented");
            /// <summary>
            /// The amount of detail provided by the event.
            /// </summary>
            public float Detail => JSRef!.Get<float>("detail");
            /// <summary>
            /// The object which registered the event listener.
            /// </summary>
            public EventEmitter CurrentTarget => JSRef!.Get<EventEmitter>("currentTarget");
            /// <summary>
            /// The object to which the event was originally dispatched.
            /// </summary>
            public EventEmitter Target => JSRef!.Get<EventEmitter>("target");
            /// <summary>
            /// The time at which the event was created.
            /// </summary>
            public float TimeStamp => JSRef!.Get<float>("timeStamp");
            /// <summary>
            /// The type of event.
            /// </summary>
            public string Type => JSRef!.Get<string>("type");

            /// <summary>
            /// Prevents certain events from being further propagated.
            /// </summary>
            public void StopPropagation() => JSRef!.CallVoid("stopPropagation");
            /// <summary>
            /// Prevents other listeners of the same event from being called.
            /// </summary>
            public void StopImmediatePropagation() => JSRef!.CallVoid("stopImmediatePropagation");
            /// <summary>
            /// Cancels the event (if it is cancelable).
            /// </summary>
            public void PreventDefault() => JSRef!.CallVoid("preventDefault");
        }
    }
}
