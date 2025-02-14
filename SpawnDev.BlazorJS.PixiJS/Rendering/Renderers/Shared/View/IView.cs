using Microsoft.JSInterop;

namespace SpawnDev.BlazorJS.PixiJS
{
    public static partial class PIXI
    {
        /// <summary>
        /// A view is something that is able to be rendered by the renderer.
        /// </summary>
        public interface IView
        {
            /// <summary>
            /// a unique id for this view
            /// </summary>
            long Uid { get; }
            /// <summary>
            /// whether or not this view should be batched
            /// </summary>
            bool Batched { get; set; }
            /// <summary>
            /// an identifier that is used to identify the type of system that will be used to render this renderable<br/>
            /// eg, 'sprite' will use the sprite system(based on the systems name
            /// </summary>
            string RenderPipeId { get; }
            /// <summary>
            /// Whether or not to round the x/y position of the object.
            /// </summary>
            bool RoundPixels { get; set; }
            /// <summary>
            /// this is the AABB rectangle bounds of the view in local untransformed space.
            /// </summary>
            BoundsData Bounds { get; set; }
            /// <summary>
            /// Checks if the point is within the view
            /// </summary>
            /// <param name="point"></param>
            /// <returns></returns>
            bool ContainsPoint(Point point);
        }
    }
}
