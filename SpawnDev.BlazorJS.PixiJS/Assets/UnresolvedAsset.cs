using System.Text.Json.Serialization;

namespace SpawnDev.BlazorJS.PixiJS
{
    public static partial class PIXI
    {
        /// <summary>
        /// An asset that has not been resolved yet.
        /// </summary>
        public class UnresolvedAsset
        {
            /// <summary>
            /// Asset id
            /// </summary>
            public string Key { get; set; }
            /// <summary>
            /// The URL or relative path to the asset
            /// </summary>
            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
            public string? Src { get; set; }
            /// <summary>
            /// Aliases associated with asset
            /// </summary>
            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
            public Union<IEnumerable<string>, string>? Alias { get; set; }
        }
    }
}
