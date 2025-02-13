using Microsoft.JSInterop;

namespace SpawnDev.BlazorJS.PixiJS
{
    public static partial class PIXI
    {
        /// <summary>
        ///  * The Point object represents a location in a two-dimensional coordinate system, where `x` represents the position on the 
        ///  horizontal axis and `y` represents the position on the vertical axis. Many Pixi functions accept the `PointData` type as 
        ///  an alternative to `Point`, which only requires `x` and `y` properties.<br/>
        ///  https://pixijs.download/release/docs/maths.Point.html
        /// </summary>
        public class Point : PointLike
        {
            /// <inheritdoc/>
            public Point(IJSInProcessObjectReference _ref) : base(_ref) { }
            /// <summary>
            /// Creates a new Point
            /// </summary>
            /// <param name="x"></param>
            /// <param name="y"></param>
            public Point(float x = 0, float y = 0) : base(JS.New("PIXI.Point", x, y)) { }
            /// <summary>
            /// Creates a clone of this point
            /// </summary>
            /// <returns></returns>
            public Point Clone() => JSRef!.Call<Point>("clone");
            #region Math Extras
            /// <summary>
            /// Adds other to this point and outputs into outPoint or a new Point.<br/>
            /// Note: Only available with pixi.js/math-extras.
            /// </summary>
            /// <typeparam name="TPointData"></typeparam>
            /// <param name="other"></param>
            /// <param name="outPoint"></param>
            /// <returns></returns>
            public TPointData Add<TPointData>(IPointData other, TPointData outPoint) where TPointData : IPointData => JSRef!.Call<TPointData>("add", other, outPoint);
            /// <summary>
            /// Adds other to this point and outputs into outPoint or a new Point.<br/>
            /// Note: Only available with pixi.js/math-extras.
            /// </summary>
            /// <param name="other"></param>
            /// <param name="outPoint"></param>
            /// <returns></returns>
            public void Add(IPointData other, IPointData outPoint) => JSRef!.CallVoid("add", other, outPoint);
            /// <summary>
            /// Adds other to this point and outputs into outPoint or a new Point.<br/>
            /// Note: Only available with pixi.js/math-extras.
            /// </summary>
            /// <param name="other"></param>
            /// <returns></returns>
            public Point Add(IPointData other) => JSRef!.Call<Point>("add", other);
            /// <summary>
            /// Adds other to this point and outputs into outPoint or a new Point.<br/>
            /// Note: Only available with pixi.js/math-extras.
            /// </summary>
            /// <typeparam name="TPointData"></typeparam>
            /// <param name="other"></param>
            /// <returns></returns>
            public TPointData Add<TPointData>(IPointData other) where TPointData : IPointData => JSRef!.Call<TPointData>("add", other);

            // TODO
            #endregion
        }
    }
}
