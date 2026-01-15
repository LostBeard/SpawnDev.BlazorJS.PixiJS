using Microsoft.JSInterop;

namespace SpawnDev.BlazorJS.PixiJS
{
    public static partial class PIXI
    {
        public class Texture : JSObject
        {
            #region Constructors
            /// <summary>
            /// Deserialization constructor
            /// </summary>
            /// <param name="_ref"></param>
            public Texture(IJSInProcessObjectReference _ref) : base(_ref) { }
            #endregion
            #region Properties
            /// <summary>
            /// The height of the Texture in pixels.
            /// </summary>
            public float Height => JSRef!.Get<float>("height");
            /// <summary>
            /// The width of the Texture in pixels.
            /// </summary>
            public float Width => JSRef!.Get<float>("width");
            /// <summary>
            /// The label of the texture.
            /// </summary>
            public string? Label { get => JSRef!.Get<string?>("label"); set => JSRef!.Set("label", value); }
            /// <summary>
            /// The frame specifies the region of the base texture that this texture uses.
            /// </summary>
            public Rectangle Frame => JSRef!.Get<Rectangle>("frame");
            /// <summary>
            /// The resolution of the texture. Valid values: 1, 2, etc.
            /// </summary>
            public float Resolution => JSRef!.Get<float>("resolution");
            /// <summary>
            /// This is the area of the BaseTexture that this texture uses to render.
            /// </summary>
            /// <returns></returns>
            public Rectangle Uvs => JSRef!.Get<Rectangle>("uvs");
            /// <summary>
            /// The source that the texture is being rendered from.
            /// </summary>
            public TextureSource Source => JSRef!.Get<TextureSource>("source");
            #endregion
            #region Methods
            /// <summary>
            /// Helper function that creates a new Texture based on the source you provide. The source can be - frame id, image url, video url, canvas element, video element, base texture
            /// </summary>
            /// <param name="source"></param>
            /// <param name="skipCache"></param>
            /// <param name="options"></param>
            /// <returns></returns>
            public static Texture From(string source, bool skipCache = false, TextureOptions? options = null) => JS.Call<Texture>("PIXI.Texture.from", source, skipCache, options);
            /// <summary>
            /// Destroys this texture
            /// </summary>
            /// <param name="destroyBase"></param>
            public void Destroy(bool destroyBase = false) => JSRef!.CallVoid("destroy", destroyBase);
            #endregion
            #region Events

            #endregion
        }
    }
}
