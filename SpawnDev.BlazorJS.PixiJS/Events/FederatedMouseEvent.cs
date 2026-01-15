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
            /// <summary>
            /// The button number that was pressed when the mouse event was fired.
            /// </summary>
            public int Button => JSRef!.Get<int>("button");
            /// <summary>
            /// The buttons being pressed when the mouse event was fired.
            /// </summary>
            public int Buttons => JSRef!.Get<int>("buttons");
            /// <summary>
            /// Whether the 'ctrl' key was pressed when this event occurred.
            /// </summary>
            public bool CtrlKey => JSRef!.Get<bool>("ctrlKey");
            /// <summary>
            /// Whether the 'meta' key was pressed when this event occurred.
            /// </summary>
            public bool MetaKey => JSRef!.Get<bool>("metaKey");
            /// <summary>
            /// Whether the 'shift' key was pressed when this event occurred.
            /// </summary>
            public bool ShiftKey => JSRef!.Get<bool>("shiftKey");
            /// <summary>
            /// The X coordinate of the mouse pointer in local (DOM content) coordinates.
            /// </summary>
            public float ClientX => JSRef!.Get<float>("clientX");
            /// <summary>
            /// The Y coordinate of the mouse pointer in local (DOM content) coordinates.
            /// </summary>
            public float ClientY => JSRef!.Get<float>("clientY");
            /// <summary>
            /// The X coordinate of the mouse pointer relative to the position of the last event.
            /// </summary>
            public float MovementX => JSRef!.Get<float>("movementX");
            /// <summary>
            /// The Y coordinate of the mouse pointer relative to the position of the last event.
            /// </summary>
            public float MovementY => JSRef!.Get<float>("movementY");
            /// <summary>
            /// The X coordinate of the mouse pointer relative to the whole document.
            /// </summary>
            public float PageX => JSRef!.Get<float>("pageX");
            /// <summary>
            /// The Y coordinate of the mouse pointer relative to the whole document.
            /// </summary>
            public float PageY => JSRef!.Get<float>("pageY");
            /// <summary>
            /// The X coordinate of the mouse pointer in global (screen) coordinates.
            /// </summary>
            public float ScreenX => JSRef!.Get<float>("screenX");
            /// <summary>
            /// The Y coordinate of the mouse pointer in global (screen) coordinates.
            /// </summary>
            public float ScreenY => JSRef!.Get<float>("screenY");
            /// <summary>
            /// The global point of the event.
            /// </summary>
            public Point Global => JSRef!.Get<Point>("global");
            /// <summary>
            /// The offset point of the event.
            /// </summary>
            public Point Offset => JSRef!.Get<Point>("offset");
        }
    }
}
