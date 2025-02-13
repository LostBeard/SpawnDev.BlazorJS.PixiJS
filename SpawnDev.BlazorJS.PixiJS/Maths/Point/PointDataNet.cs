namespace SpawnDev.BlazorJS.PixiJS
{
    public static partial class PIXI
    {
        /// <summary>
        /// Implements IPointData.
        /// </summary>
        public class PointDataNet : IPointData
        {
            /// <inheritdoc/>
            public float X { get; set; }
            /// <inheritdoc/>
            public float Y { get; set; }
        }
    }
}
