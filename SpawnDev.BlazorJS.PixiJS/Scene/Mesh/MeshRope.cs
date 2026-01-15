using Microsoft.JSInterop;

namespace SpawnDev.BlazorJS.PixiJS
{
    public static partial class PIXI
    {
        /// <summary>
        /// The material Rope allows you to draw a texture across several points and then manipulate these points.<br/>
        /// https://pixijs.download/v8.14.3/docs/scene.MeshRope.html
        /// </summary>
        public class MeshRope : MeshSimple
        {
            /// <summary>
            /// Deserialization constructor
            /// </summary>
            public MeshRope(IJSInProcessObjectReference _ref) : base(_ref) { }

            /// <summary>
            /// Creates a new MeshRope instance.
            /// </summary>
            /// <param name="options">The options to use.</param>
            public MeshRope(MeshRopeOptions options) : base(JS.New("PIXI.MeshRope", options)) { }

            /// <summary>
            /// Creates a new MeshRope instance.
            /// </summary>
            /// <param name="texture">The texture to use on the rope.</param>
            /// <param name="points">An array of {PIXI.Point} objects to construct this rope.</param>
            /// <param name="textureScale">Optional. Positive values scale rope texture keeping its aspect ratio. You can reduce alpha channel artifacts by providing a larger texture and downscaling here. If set to zero, texture will be stretched instead.</param>
            public MeshRope(Texture texture, Point[] points, float textureScale = 0)
                : this(CreateMeshRopeOptions(texture, points, textureScale)) { }

            static MeshRopeOptions CreateMeshRopeOptions(Texture texture, Point[] points, float textureScale = 0)
            {
                var options = new MeshRopeOptions();
                options.Texture = texture;
                options.Points = points;
                options.TextureScale = textureScale;
                return options;
            }
        }
    }
}
