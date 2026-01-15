using SpawnDev.BlazorJS.JsonConverters;
using SpawnDev.BlazorJS.JSObjects;
using System.Text.Json.Serialization;
using Microsoft.JSInterop;

namespace SpawnDev.BlazorJS.PixiJS
{
    public class VideoSource : TextureSource
    {
        public VideoSource(IJSInProcessObjectReference _ref) : base(_ref) { }
        
        /// <summary>
        /// When true, the texture will auto-update from the video.
        /// </summary>
        public bool AutoUpdate { get => JSRef!.Get<bool>("autoUpdate"); set => JSRef!.Set("autoUpdate", value); }
        
        /// <summary>
        /// How many times a second the texture should be updated from the video. 
        /// Leave at 0 to update at every render.
        /// </summary>
        public float UpdateFPS { get => JSRef!.Get<float>("updateFPS"); set => JSRef!.Set("updateFPS", value); }

        /// <summary>
        /// The video element.
        /// </summary>
        public HTMLVideoElement Source => JSRef!.Get<HTMLVideoElement>("source");

        /// <summary>
        /// Returns true if the video is ready to be played.
        /// </summary>
        public bool IsReady => JSRef!.Get<bool>("isReady");

        /// <summary>
        /// Returns true if the video is valid.
        /// </summary>
        public bool IsValid => JSRef!.Get<bool>("isValid");
    }
}
