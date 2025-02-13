namespace SpawnDev.BlazorJS.PixiJS
{
    public static partial class PIXI
    {
        /// <summary>
        /// Common interface for points. Both Point and ObservablePoint implement it<br/>
        /// https://pixijs.download/release/docs/maths.PointData.html
        /// </summary>
        public interface IPointData
        {
            /// <summary>
            /// X coord
            /// </summary>
            float X { get; set; }
            /// <summary>
            /// Y coord
            /// </summary>
            float Y { get; set; }
        }
    }
}
