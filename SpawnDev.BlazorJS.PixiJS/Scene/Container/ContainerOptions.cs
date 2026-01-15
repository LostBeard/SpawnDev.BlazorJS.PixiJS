using Microsoft.JSInterop;

namespace SpawnDev.BlazorJS.PixiJS
{
    public static partial class PIXI
    {
        /// <summary>
        /// Options for the Container constructor.<br/>
        /// https://pixijs.download/release/docs/scene.ContainerOptions.html
        /// </summary>
        public class ContainerOptions : JSObject
        {
            /// <summary>
            /// Deserialization constructor
            /// </summary>
            public ContainerOptions(IJSInProcessObjectReference _ref) : base(_ref) { }

            /// <summary>
            /// Creates a new instance
            /// </summary>
            public ContainerOptions() : base(JS.New("Object")) { }

            /// <summary>
            /// The opacity of the object.
            /// </summary>
            public float? Alpha { get => JSRef!.Get<float?>("alpha"); set => JSRef!.Set("alpha", value); }

            /// <summary>
            /// The angle of the object in degrees.
            /// </summary>
            public float? Angle { get => JSRef!.Get<float?>("angle"); set => JSRef!.Set("angle", value); }

            /// <summary>
            /// The visibility of the object.
            /// </summary>
            public bool? Visible { get => JSRef!.Get<bool?>("visible"); set => JSRef!.Set("visible", value); }

            /// <summary>
            /// The x coordinate of the object.
            /// </summary>
            public float? X { get => JSRef!.Get<float?>("x"); set => JSRef!.Set("x", value); }

            /// <summary>
            /// The y coordinate of the object.
            /// </summary>
            public float? Y { get => JSRef!.Get<float?>("y"); set => JSRef!.Set("y", value); }

            /// <summary>
            /// The rotation of the object in radians.
            /// </summary>
            public float? Rotation { get => JSRef!.Get<float?>("rotation"); set => JSRef!.Set("rotation", value); }

            /// <summary>
            /// The z-index of the object.
            /// </summary>
            public int? ZIndex { get => JSRef!.Get<int?>("zIndex"); set => JSRef!.Set("zIndex", value); }

            /// <summary>
            /// The label of the object.
            /// </summary>
            public string? Label { get => JSRef!.Get<string?>("label"); set => JSRef!.Set("label", value); }
        }
    }
}
