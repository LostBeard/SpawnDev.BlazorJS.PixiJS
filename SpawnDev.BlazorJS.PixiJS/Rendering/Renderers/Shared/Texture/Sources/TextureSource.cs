using Microsoft.JSInterop;

namespace SpawnDev.BlazorJS.PixiJS
{
    /// <summary>
    /// A texture source store the information that represents an image or part of an image.
    /// https://pixijs.download/release/docs/rendering.TextureSource.html
    /// </summary>
    public class TextureSource : JSObject
    {
        /// <summary>
        /// Deserialization constructor
        /// </summary>
        public TextureSource(IJSInProcessObjectReference _ref) : base(_ref) { }

        /// <summary>
        /// The label of the source.
        /// </summary>
        public string Label { get => JSRef!.Get<string>("label"); set => JSRef!.Set("label", value); }
        /// <summary>
        /// The width of the source.
        /// </summary>
        public float Width { get => JSRef!.Get<float>("width"); set => JSRef!.Set("width", value); }
        /// <summary>
        /// The height of the source.
        /// </summary>
        public float Height { get => JSRef!.Get<float>("height"); set => JSRef!.Set("height", value); }
        /// <summary>
        /// The format of the source.
        /// </summary>
        public string Format { get => JSRef!.Get<string>("format"); }
        /// <summary>
        /// The pixel width of the source.
        /// </summary>
        public int PixelWidth { get => JSRef!.Get<int>("pixelWidth"); }
        /// <summary>
        /// The pixel height of the source.
        /// </summary>
        public int PixelHeight { get => JSRef!.Get<int>("pixelHeight"); }

        /// <summary>
        /// Width of source.
        /// </summary>
        public float SourceWidth { get => JSRef!.Get<float>("width"); }

        /// <summary>
        /// Height of source.
        /// </summary>
        public float SourceHeight { get => JSRef!.Get<float>("height"); }

        /// <summary>
        /// Scale mode to apply when scaling this texture.
        /// </summary>
        public string ScaleMode { get => JSRef!.Get<string>("scaleMode"); set => JSRef!.Set("scaleMode", value); }
    }
}
