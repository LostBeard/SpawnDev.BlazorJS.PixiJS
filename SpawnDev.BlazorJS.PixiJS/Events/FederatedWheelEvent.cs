using Microsoft.JSInterop;

namespace SpawnDev.BlazorJS.PixiJS
{
    public static partial class PIXI
    {
        /// <summary>
        /// A FederatedEvent that includes wheel interaction data.<br/>
        /// https://pixijs.download/v8.14.3/docs/events.FederatedWheelEvent.html
        /// </summary>
        public class FederatedWheelEvent : FederatedMouseEvent
        {
            /// <summary>
            /// Deserialization constructor
            /// </summary>
            public FederatedWheelEvent(IJSInProcessObjectReference _ref) : base(_ref) { }

            /// <summary>
            /// The horizontal scroll amount.
            /// </summary>
            public float DeltaX => JSRef!.Get<float>("deltaX");

            /// <summary>
            /// The vertical scroll amount.
            /// </summary>
            public float DeltaY => JSRef!.Get<float>("deltaY");

            /// <summary>
            /// The z-axis scroll amount.
            /// </summary>
            public float DeltaZ => JSRef!.Get<float>("deltaZ");

            /// <summary>
            /// The unit of the delta values. 0: pixels, 1: lines, 2: pages.
            /// </summary>
            public int DeltaMode => JSRef!.Get<int>("deltaMode");
        }
    }
}
