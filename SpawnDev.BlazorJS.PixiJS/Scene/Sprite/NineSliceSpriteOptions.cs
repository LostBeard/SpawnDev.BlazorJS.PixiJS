using System.Text.Json.Serialization;

namespace SpawnDev.BlazorJS.PixiJS
{
    public static partial class PIXI
    {
        /// <summary>
        /// Options for the NineSliceSprite constructor.<br/>
        /// https://pixijs.download/release/docs/scene.NineSliceSpriteOptions.html
        /// </summary>
        public class NineSliceSpriteOptions : SpriteOptions
        {
            /// <summary>
            /// The width of the left slice.
            /// </summary>
            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
            [JsonPropertyName("leftWidth")]
            public float? LeftWidth { get; set; }

            /// <summary>
            /// The height of the top slice.
            /// </summary>
            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
            [JsonPropertyName("topHeight")]
            public float? TopHeight { get; set; }

            /// <summary>
            /// The width of the right slice.
            /// </summary>
            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
            [JsonPropertyName("rightWidth")]
            public float? RightWidth { get; set; }

            /// <summary>
            /// The height of the bottom slice.
            /// </summary>
            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
            [JsonPropertyName("bottomHeight")]
            public float? BottomHeight { get; set; }
        }
    }
}
