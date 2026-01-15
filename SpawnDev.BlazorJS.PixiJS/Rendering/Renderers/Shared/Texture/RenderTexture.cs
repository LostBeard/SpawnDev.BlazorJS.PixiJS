using Microsoft.JSInterop;

namespace SpawnDev.BlazorJS.PixiJS
{
    public static partial class PIXI
    {
        /// <summary>
        /// A RenderTexture is a special texture that allows any PixiJS display object to be rendered to it.<br/>
        /// https://pixijs.download/v8.14.3/docs/rendering.RenderTexture.html
        /// </summary>
        public class RenderTexture : Texture
        {
            /// <summary>
            /// Deserialization constructor
            /// </summary>
            public RenderTexture(IJSInProcessObjectReference _ref) : base(_ref) { }

            /// <summary>
            /// A helper method that creates a new RenderTexture.
            /// </summary>
            /// <param name="options">The options for the render texture.</param>
            /// <returns>A new RenderTexture.</returns>
            public static RenderTexture Create(RenderTextureOptions options) => JS.Call<RenderTexture>("PIXI.RenderTexture.create", options);

            /// <summary>
            /// Resizes the RenderTexture.
            /// </summary>
            /// <param name="width">The new width of the render texture.</param>
            /// <param name="height">The new height of the render texture.</param>
            /// <param name="resolution">The new resolution of the render texture.</param>
            public void Resize(float width, float height, float resolution = 1) => JSRef!.CallVoid("resize", width, height, resolution);
        }

        /// <summary>
        /// Options for creating a RenderTexture.
        /// </summary>
        public class RenderTextureOptions : JSObject
        {
            /// <summary>
            /// Deserialization constructor
            /// </summary>
            public RenderTextureOptions(IJSInProcessObjectReference _ref) : base(_ref) { }

            /// <summary>
            /// Creates a new instance
            /// </summary>
            public RenderTextureOptions() : base(JS.New("Object")) { }

            /// <summary>
            /// The width of the render texture.
            /// </summary>
            public int? Width { get => JSRef!.Get<int?>("width"); set => JSRef!.Set("width", value); }

            /// <summary>
            /// The height of the render texture.
            /// </summary>
            public int? Height { get => JSRef!.Get<int?>("height"); set => JSRef!.Set("height", value); }

            /// <summary>
            /// The resolution of the render texture.
            /// </summary>
            public float? Resolution { get => JSRef!.Get<float?>("resolution"); set => JSRef!.Set("resolution", value); }
        }
    }
}
