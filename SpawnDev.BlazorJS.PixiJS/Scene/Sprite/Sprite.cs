using Microsoft.JSInterop;

namespace SpawnDev.BlazorJS.PixiJS
{
    public static partial class PIXI
    {
        /// <summary>
        /// The Sprite object is one of the most important objects in PixiJS. It is a drawing item that can be added to a scene and rendered to the screen.
        /// </summary>
        public class Sprite : Container, IView
        {
            #region Constructors
            /// <summary>
            /// Deserialization constructor
            /// </summary>
            /// <param name="_ref"></param>
            public Sprite(IJSInProcessObjectReference _ref) : base(_ref) { }
            /// <summary>
            /// Creates a new instance
            /// </summary>
            /// <param name="texture"></param>
            public Sprite(Texture texture) : base(JS.New("PIXI.Sprite", texture)) { }
            /// <summary>
            /// Creates a new instance
            /// </summary>
            /// <param name="options"></param>
            public Sprite(SpriteOptions options) : base(JS.New("PIXI.Sprite", options)) { }
            #endregion
            #region Properties
            /// <summary>
            /// a unique id for this view
            /// </summary>
            public long Uid => JSRef!.Get<long>("uid");
            /// <summary>
            /// whether or not this view should be batched
            /// </summary>
            public bool Batched { get => JSRef!.Get<bool>("batched"); set => JSRef!.Set("batched", value); }
            /// <summary>
            /// an identifier that is used to identify the type of system that will be used to render this renderable<br/>
            /// eg, 'sprite' will use the sprite system(based on the systems name
            /// </summary>
            public string? RenderPipeId { get => JSRef!.Get<string?>("renderPipeId"); set => JSRef!.Set("renderPipeId", value); }
            /// <summary>
            /// Whether or not to round the x/y position of the object.
            /// </summary>
            public bool RoundPixels { get => JSRef!.Get<bool>("roundPixels"); set => JSRef!.Set("roundPixels", value); }
            /// <summary>
            /// this is the AABB rectangle bounds of the view in local untransformed space.
            /// </summary>
            public BoundsData? Bounds { get => JSRef!.Get<BoundsData?>("bounds"); set => JSRef!.Set("bounds", value); }
            #endregion
            #region Methods
            /// <summary>
            /// Adds the current bounds of this view to the supplied bounds
            /// </summary>
            /// <param name="bounds"></param>
            /// <exception cref="NotImplementedException"></exception>
            public void AddBounds(Bounds bounds) => JSRef!.CallVoid("addBounds", bounds);
            /// <summary>
            /// Checks if the point is within the view
            /// </summary>
            /// <param name="point"></param>
            /// <returns></returns>
            public bool ContainsPoint(Point point) => JSRef!.Call<bool>("containsPoint", point);
            #endregion
            #region Events

            #endregion
        }
    }
}
