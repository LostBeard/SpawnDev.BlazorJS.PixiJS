using System.Text.Json.Serialization;

namespace SpawnDev.BlazorJS.PixiJS
{
    public static partial class PIXI
    {
        /// <summary>
        /// Options for the Container constructor.<br/>
        /// https://pixijs.download/release/docs/scene.ContainerOptions.html
        /// </summary>
        public class ContainerOptions
        {
            /// <summary>
            /// The opacity of the object.
            /// </summary>
            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
            [JsonPropertyName("alpha")]
            public float? Alpha { get; set; }

            /// <summary>
            /// The angle of the object in degrees.
            /// </summary>
            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
            [JsonPropertyName("angle")]
            public float? Angle { get; set; }

            /// <summary>
            /// The visibility of the object.
            /// </summary>
            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
            [JsonPropertyName("visible")]
            public bool? Visible { get; set; }

            /// <summary>
            /// The x coordinate of the object.
            /// </summary>
            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
            [JsonPropertyName("x")]
            public float? X { get; set; }

            /// <summary>
            /// The y coordinate of the object.
            /// </summary>
            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
            [JsonPropertyName("y")]
            public float? Y { get; set; }

            /// <summary>
            /// The rotation of the object in radians.
            /// </summary>
            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
            [JsonPropertyName("rotation")]
            public float? Rotation { get; set; }

            /// <summary>
            /// The z-index of the object.
            /// </summary>
            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
            [JsonPropertyName("zIndex")]
            public int? ZIndex { get; set; }

            /// <summary>
            /// The label of the object.
            /// </summary>
            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
            [JsonPropertyName("label")]
            public string? Label { get; set; }

            /// <summary>
            /// The name of the object.
            /// </summary>
            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
            [JsonPropertyName("name")]
            public string? Name { get; set; }
        }
    }
}
