namespace SpawnDev.BlazorJS.PixiJS
{
    /// <summary>
    /// An effect that can be applied to a container. This is used to create effects such as filters/masks etc.
    /// </summary>
    public static partial class PIXI
    {
        /// <summary>
        /// An effect that can be applied to a container. This is used to create effects such as filters/masks etc.
        /// https://pixijs.download/release/docs/scene.Effect.html
        /// </summary>
        public interface Effect
        {
            /// <summary>
            /// The pipe to render this effect with
            /// </summary>
            string Pipe { get; set; }
            /// <summary>
            /// The priority of the effect
            /// </summary>
            float Priority { get; set; }
            /// <summary>
            /// Destroy this effect
            /// </summary>
            void Destroy();
        }
    }
}
