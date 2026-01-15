using SpawnDev.BlazorJS.JsonConverters;
using SpawnDev.BlazorJS.JSObjects;
using System.Text.Json.Serialization;
using Microsoft.JSInterop;

namespace SpawnDev.BlazorJS.PixiJS
{
    public class TextureSource : JSObject
    {
        public TextureSource(IJSInProcessObjectReference _ref) : base(_ref) { }

        public string Label { get => JSRef!.Get<string>("label"); set => JSRef!.Set("label", value); }
        public float Width { get => JSRef!.Get<float>("width"); set => JSRef!.Set("width", value); }
        public float Height { get => JSRef!.Get<float>("height"); set => JSRef!.Set("height", value); }
        public string Format { get => JSRef!.Get<string>("format"); }
        public int PixelWidth { get => JSRef!.Get<int>("pixelWidth"); }
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
