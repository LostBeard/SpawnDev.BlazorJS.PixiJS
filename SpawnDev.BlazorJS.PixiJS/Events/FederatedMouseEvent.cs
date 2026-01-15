using Microsoft.JSInterop;

namespace SpawnDev.BlazorJS.PixiJS
{
    public static partial class PIXI
    {
        /// <summary>
        /// A FederatedEvent that includes mouse interaction data.<br/>
        /// https://pixijs.download/v8.14.3/docs/events.FederatedMouseEvent.html
        /// </summary>
        public class FederatedMouseEvent : FederatedEvent
        {
            /// <summary>
            /// Deserialization constructor
            /// </summary>
            public FederatedMouseEvent(IJSInProcessObjectReference _ref) : base(_ref) { }
            
            /// <summary>
            /// Whether the 'alt' key was pressed when this event occurred.
            /// </summary>
            public bool AltKey => JSRef!.Get<bool>("altKey");
            public int Button => JSRef!.Get<int>("button");
            public int Buttons => JSRef!.Get<int>("buttons");
            public bool CtrlKey => JSRef!.Get<bool>("ctrlKey");
            public bool MetaKey => JSRef!.Get<bool>("metaKey");
            public bool ShiftKey => JSRef!.Get<bool>("shiftKey");
            public float ClientX => JSRef!.Get<float>("clientX");
            public float ClientY => JSRef!.Get<float>("clientY");
            public float MovementX => JSRef!.Get<float>("movementX");
            public float MovementY => JSRef!.Get<float>("movementY");
            public float PageX => JSRef!.Get<float>("pageX");
            public float PageY => JSRef!.Get<float>("pageY");
            public float ScreenX => JSRef!.Get<float>("screenX");
            public float ScreenY => JSRef!.Get<float>("screenY");
            public Point Global => JSRef!.Get<Point>("global");
            public Point Offset => JSRef!.Get<Point>("offset");
        }
    }
}
