using Microsoft.JSInterop;

namespace SpawnDev.BlazorJS.PixiJS
{
    public static partial class PIXI
    {
        /// <summary>
        /// An AnimatedSprite is a simple way to display an animation depicted by a list of textures.<br/>
        /// https://pixijs.download/v8.14.3/docs/scene.AnimatedSprite.html
        /// </summary>
        public class AnimatedSprite : Sprite
        {
            /// <summary>
            /// Deserialization constructor
            /// </summary>
            public AnimatedSprite(IJSInProcessObjectReference _ref) : base(_ref) { }

            /// <summary>
            /// Creates a new AnimatedSprite instance.
            /// </summary>
            /// <param name="options">Options for the AnimatedSprite</param>
            public AnimatedSprite(AnimatedSpriteOptions options) : base(JS.New("PIXI.AnimatedSprite", options)) { }

            /// <summary>
            /// Creates a new AnimatedSprite instance.
            /// </summary>
            /// <param name="textures">An array of Texture objects that make up the animation.</param>
            /// <param name="autoUpdate">Whether to use PIXI.Ticker.shared to auto update animation time.</param>
            public AnimatedSprite(Texture[] textures, bool autoUpdate = true) : this(new AnimatedSpriteOptions { Textures = textures, AutoUpdate = autoUpdate }) { }

            /// <summary>
            /// The speed that the AnimatedSprite will play at. Higher is faster.
            /// </summary>
            public float AnimationSpeed { get => JSRef!.Get<float>("animationSpeed"); set => JSRef!.Set("animationSpeed", value); }

            /// <summary>
            /// Whether to use PIXI.Ticker.shared to auto update animation time.
            /// </summary>
            public bool AutoUpdate { get => JSRef!.Get<bool>("autoUpdate"); set => JSRef!.Set("autoUpdate", value); }

            /// <summary>
            /// Whether or not the animate sprite repeats after playing.
            /// </summary>
            public bool Loop { get => JSRef!.Get<bool>("loop"); set => JSRef!.Set("loop", value); }

            /// <summary>
            /// Whether or not the animate sprite is currently playing.
            /// </summary>
            public bool Playing => JSRef!.Get<bool>("playing");

            /// <summary>
            /// The total number of frames in the AnimatedSprite. This is the same as textures.length.
            /// </summary>
            public int TotalFrames => JSRef!.Get<int>("totalFrames");

            /// <summary>
            /// The AnimatedSprites current frame index.
            /// </summary>
            public int CurrentFrame { get => JSRef!.Get<int>("currentFrame"); set => JSRef!.Set("currentFrame", value); }

            /// <summary>
            /// Plays the AnimatedSprite.
            /// </summary>
            public void Play() => JSRef!.CallVoid("play");

            /// <summary>
            /// Stops the AnimatedSprite.
            /// </summary>
            public void Stop() => JSRef!.CallVoid("stop");

            /// <summary>
            /// Goes to a specific frame and begins playing the AnimatedSprite.
            /// </summary>
            /// <param name="frameNumber">Frame index to start at.</param>
            public void GotoAndPlay(int frameNumber) => JSRef!.CallVoid("gotoAndPlay", frameNumber);

            /// <summary>
            /// Stops the AnimatedSprite and goes to a specific frame.
            /// </summary>
            /// <param name="frameNumber">Frame index to stop at.</param>
            public void GotoAndStop(int frameNumber) => JSRef!.CallVoid("gotoAndStop", frameNumber);
        }
    }
}
