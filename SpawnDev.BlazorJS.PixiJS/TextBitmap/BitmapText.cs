using Microsoft.JSInterop;

namespace SpawnDev.BlazorJS.PixiJS
{
    public static partial class PIXI
    {
        /// <summary>
        /// A BitmapText object will create a line or multiple lines of text using bitmap font.<br/>
        /// The primary advantage of this class over Text is that all of your textures are pre-generated and loading, meaning that rendering fast, and changing text has no performance implications.<br/>
        /// https://api.pixijs.io/@pixi/text-bitmap/PIXI/BitmapText.html
        /// https://pixijs.download/v4.3.1/docs/PIXI.extras.BitmapText.html
        /// </summary>
        public class BitmapText : Container, View
        {
            #region Constructors
            /// <summary>
            /// Deserialization constructor
            /// </summary>
            /// <param name="_ref"></param>
            public BitmapText(IJSInProcessObjectReference _ref) : base(_ref) { }
            /// <summary>
            /// Creates a new instance
            /// </summary>
            /// <param name="text"></param>
            /// <param name="style"></param>
            public BitmapText(string text, object style) : base(JS.New("PIXI.BitmapText", text, style)) { }
            #endregion
            #region Properties
            /// <summary>
            /// The alignment of the BitmapText object.
            /// </summary>
            public string Align { get => JSRef!.Get<string>("align"); set => JSRef!.Set("align", value); }
            /// <summary>
            /// The anchor sets the origin point of the text.
            /// </summary>
            public ObservablePoint Anchor => JSRef!.Get<ObservablePoint>("anchor");
            /// <summary>
            /// The width of the overall text, different from fontSize, which is defined in the style object.
            /// </summary>
            public float TextWidth => JSRef!.Get<float>("textWidth");
            /// <summary>
            /// The height of the overall text, different from fontSize, which is defined in the style object.
            /// </summary>
            public float TextHeight => JSRef!.Get<float>("textHeight");
            /// <summary>
            /// The text to display.
            /// </summary>
            public string Text { get => JSRef!.Get<string>("text"); set => JSRef!.Set("text", value); }
            /// <summary>
            /// The max width of the text before line wrapping.
            /// </summary>
            public float MaxWidth { get => JSRef!.Get<float>("maxWidth"); set => JSRef!.Set("maxWidth", value); }
            /// <summary>
            /// The letter spacing of the text.
            /// </summary>
            public float LetterSpacing { get => JSRef!.Get<float>("letterSpacing"); set => JSRef!.Set("letterSpacing", value); }
            /// <summary>
            /// The tint of the BitmapText object.
            /// </summary>
            public int Tint { get => JSRef!.Get<int>("tint"); set => JSRef!.Set("tint", value); }

            #endregion
            #region Methods
            /// <summary>
            /// Updates the transform on all children of this container for rendering.
            /// </summary>
            public void UpdateTransform() => JSRef!.CallVoid("updateTransform");

            #endregion

            #region View Interface

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
        }
    }
}
