namespace SpawnDev.BlazorJS.PixiJS
{
    public static partial class PIXI
    {
        /// <summary>
        /// Defines a size with a width and a height.<br/>
        /// https://pixijs.download/release/docs/maths.Size.html
        /// </summary>
        public interface ISize
        {
            /// <summary>
            /// The width
            /// </summary>
            float Width { get; set; }
            /// <summary>
            /// The height
            /// </summary>
            float Height { get; set; }
        }
    }
}