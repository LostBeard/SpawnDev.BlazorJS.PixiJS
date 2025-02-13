namespace SpawnDev.BlazorJS.PixiJS
{
    public static partial class PIXI
    {
        /// <summary>
        /// Common interface for points. Both Point and ObservablePoint implement it<br/>
        /// https://pixijs.download/release/docs/maths.PointLike.html
        /// </summary>
        public interface IPointLike : IPointData
        {
            /// <summary>
            /// Copies x and y from the given point
            /// </summary>
            /// <param name="p">The point to copy from</param>
            /// <returns>Returns itself.</returns>
            TPointLike CopyFrom<TPointLike>(IPointLike p) where TPointLike : IPointLike;
            /// <summary>
            /// Copies x and y from the given point
            /// </summary>
            /// <param name="p">The point to copy from</param>
            void CopyFrom(IPointLike p);
            /// <summary>
            /// Copies x and y into the given point
            /// </summary>
            /// <param name="p">The point to copy.</param>
            /// <returns>Given point with values updated</returns>
            TPointLike CopyTo<TPointLike>(TPointLike p) where TPointLike : IPointLike;
            /// <summary>
            /// Copies x and y into the given point
            /// </summary>
            /// <param name="p">The point to copy.</param>
            void CopyTo(IPointLike p);
            /// <summary>
            /// Returns true if the given point is equal to this point
            /// </summary>
            /// <param name="p">The point to check</param>
            /// <returns>Whether the given point equal to this point</returns>
            bool Equals(IPointData p);
            /// <summary>
            /// Sets the point to a new x and y position. If y is omitted, both x and y will be set to x.<br/>
            /// If x is also omitted both values will be set to 0.
            /// </summary>
            /// <param name="x">position of the point on the x axis</param>
            /// <param name="y">position of the point on the y axis</param>
            void Set(float x, float y);
            /// <summary>
            /// Sets the point to a new x and y position. If y is omitted, both x and y will be set to x.<br/>
            /// If x is also omitted both values will be set to 0.
            /// </summary>
            /// <param name="x">position of the point on the x axis</param>
            void Set(float x);
            /// <summary>
            /// Sets the point to a new x and y position. If y is omitted, both x and y will be set to x.<br/>
            /// If x is also omitted both values will be set to 0.
            /// </summary>
            void Set();
        }
    }
}
