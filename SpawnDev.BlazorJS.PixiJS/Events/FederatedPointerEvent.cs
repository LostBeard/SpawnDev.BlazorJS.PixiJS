using Microsoft.JSInterop;

namespace SpawnDev.BlazorJS.PixiJS
{
    public static partial class PIXI
    {
        /// <summary>
        /// A FederatedEvent that includes pointer interaction data.<br/>
        /// https://pixijs.download/v8.14.3/docs/events.FederatedPointerEvent.html
        /// </summary>
        public class FederatedPointerEvent : FederatedMouseEvent
        {
            /// <summary>
            /// Deserialization constructor
            /// </summary>
            public FederatedPointerEvent(IJSInProcessObjectReference _ref) : base(_ref) { }

            /// <summary>
            /// The width of the pointer's contact along the x-axis.
            /// </summary>
            public float Width => JSRef!.Get<float>("width");

            /// <summary>
            /// The height of the pointer's contact along the y-axis.
            /// </summary>
            public float Height => JSRef!.Get<float>("height");

            /// <summary>
            /// Whether this is the primary pointer.
            /// </summary>
            public bool IsPrimary => JSRef!.Get<bool>("isPrimary");

            /// <summary>
            /// The type of pointer that triggered the event.
            /// </summary>
            public string PointerType => JSRef!.Get<string>("pointerType");

            /// <summary>
            /// The pressure of the pointer.
            /// </summary>
            public float Pressure => JSRef!.Get<float>("pressure");

            /// <summary>
            /// The tangential pressure of the pointer.
            /// </summary>
            public float TangentialPressure => JSRef!.Get<float>("tangentialPressure");

            /// <summary>
            /// The plane angle (in degrees, in the range of [-90, 90]) between the Y-Z plane and the plane containing both the transducer (e.g. pen stylus) axis and the Y axis.
            /// </summary>
            public float TiltX => JSRef!.Get<float>("tiltX");

            /// <summary>
            /// The plane angle (in degrees, in the range of [-90, 90]) between the X-Z plane and the plane containing both the transducer (e.g. pen stylus) axis and the X axis.
            /// </summary>
            public float TiltY => JSRef!.Get<float>("tiltY");

            /// <summary>
            /// The clockwise rotation of the pointer (e.g. pen stylus) around its own major axis in degrees, with a value in the range [0, 359].
            /// </summary>
            public float Twist => JSRef!.Get<float>("twist");

            /// <summary>
            /// The unique identifier of the pointer.
            /// </summary>
            public int PointerId => JSRef!.Get<int>("pointerId");
        }
    }
}
