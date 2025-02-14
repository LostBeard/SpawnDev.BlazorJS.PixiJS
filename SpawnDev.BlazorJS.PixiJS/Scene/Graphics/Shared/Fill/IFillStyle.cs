using Microsoft.JSInterop;
using System.Text.Json.Serialization;

namespace SpawnDev.BlazorJS.PixiJS
{
    public static partial class PIXI
    {
        /// <summary>
        /// A fill style object.
        /// </summary>
        public interface IFillStyle
        {
            /// <summary>
            /// The color to use for the fill.
            /// </summary>
            ColorSource? Color { get; set; }
            /// <summary>
            /// The alpha value to use for the fill.
            /// </summary>
            float? Alpha { get; set; }
            /// <summary>
            /// The texture to use for the fill.
            /// </summary>
            Texture? Texture { get; set; }
            /// <summary>
            /// The matrix to apply.
            /// </summary>
            Matrix? Matrix{ get; set; }
            /// <summary>
            /// The fill pattern to use.
            /// </summary>
            Union<FillPattern,FillGradient>? Fill { get; set; }
            /// <summary>
            /// The fill units to use.
            /// </summary>
            TextureSpace? TextureSpace { get; set; }
        }
        /// <summary>
        /// A stroke style object.
        /// </summary>
        public class FillStyle : IFillStyle
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
        }
    }
}
