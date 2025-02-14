using System.Text.Json.Serialization;

namespace SpawnDev.BlazorJS.PixiJS
{
    public static partial class PIXI
    {
        /// <summary>
        /// A stroke style object.
        /// </summary>
        public class StrokeStyle : IStrokeStyle
        {
            ///<inheritdoc/>
            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
            public ColorSource? Color { get; set; }
            ///<inheritdoc/>
            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
            public float? Alpha { get; set; }
            ///<inheritdoc/>
            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
            public Texture? Texture { get; set; }
            ///<inheritdoc/>
            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
            public Matrix? Matrix { get; set; }
            ///<inheritdoc/>
            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
            public Union<FillPattern, FillGradient>? Fill { get; set; }
            ///<inheritdoc/>
            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
            public TextureSpace? TextureSpace { get; set; }
            ///<inheritdoc/>
            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
            public float? Width { get; set; }
            ///<inheritdoc/>
            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
            public float? Alignment { get; set; }
            ///<inheritdoc/>
            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
            public string? Cap { get; set; }
            ///<inheritdoc/>
            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
            public string? Join { get; set; }
            ///<inheritdoc/>
            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
            public float? MiterLimit { get; set; }
            ///<inheritdoc/>
            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
            public bool? PixelLine { get; set; }
        }
    }
}
