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
            public bool Cancelable => JSRef!.Get<bool>("cancelable");
            public bool DefaultPrevented => JSRef!.Get<bool>("defaultPrevented");
            public float Detail => JSRef!.Get<float>("detail");
            public EventEmitter CurrentTarget => JSRef!.Get<EventEmitter>("currentTarget");
            public EventEmitter Target => JSRef!.Get<EventEmitter>("target");
            public float TimeStamp => JSRef!.Get<float>("timeStamp");
            public string Type => JSRef!.Get<string>("type");

            public void StopPropagation() => JSRef!.CallVoid("stopPropagation");
            public void StopImmediatePropagation() => JSRef!.CallVoid("stopImmediatePropagation");
            public void PreventDefault() => JSRef!.CallVoid("preventDefault");
        }
    }
}
