using Microsoft.JSInterop;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.PixiJS
{
    /// <summary>
    /// A texture source that comes from a video.
    /// https://pixijs.download/release/docs/rendering.VideoSource.html
    /// </summary>
    public class VideoSource : TextureSource
    {
        /// <summary>
        /// Deserialization constructor
        /// </summary>
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
