using Microsoft.JSInterop;

namespace SpawnDev.BlazorJS.PixiJS
{
    public static partial class PIXI
    {
        /// <summary>
        /// The system for handling events.<br/>
        /// https://pixijs.download/v8.14.3/docs/events.EventSystem.html
        /// </summary>
        public class EventSystem : JSObject
        {
            /// <summary>
            /// Deserialization constructor
            /// </summary>
            public EventSystem(IJSInProcessObjectReference _ref) : base(_ref) { }
            
            /// <summary>
            /// The current cursor style.
            /// </summary>
            public string Cursor { get => JSRef!.Get<string>("cursor"); set => JSRef!.Set("cursor", value); }
            
            /// <summary>
            /// The resolution used to convert between the DOM client coordinates and world coordinates.
            /// </summary>
            public float Resolution { get => JSRef!.Get<float>("resolution"); set => JSRef!.Set("resolution", value); }
            
            /// <summary>
            /// Maps x and y coordinates from the DOM to the point in world coordinates.
            /// </summary>
            public Point MapPositionToPoint(Point point, float x, float y) => JSRef!.Call<Point>("mapPositionToPoint", point, x, y);
        }
    }
}
