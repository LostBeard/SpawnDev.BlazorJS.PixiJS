using System.Text.Json.Serialization;

namespace SpawnDev.BlazorJS.PixiJS
{
    public static partial class PIXI
    {
        /// <summary>
        /// Structure of a bundle found in a {@link assets.AssetsManifest Manifest} file
        /// </summary>
        public class AssetsBundle
        {
            /// <summary>
            /// The name of the bundle
            /// </summary>
            public string Name { get; set; }
            /// <summary>
            /// The assets in the bundle
            /// </summary>
            public Union<IEnumerable<string>, IEnumerable<UnresolvedAsset>, UnresolvedAsset, string> Assets { get; set; }
        }
    }
}
