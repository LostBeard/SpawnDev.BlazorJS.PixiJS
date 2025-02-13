using Microsoft.JSInterop;
using SpawnDev.BlazorJS.JSObjects;
using System.Text.Json.Serialization;

namespace SpawnDev.BlazorJS.PixiJS
{
    public static partial class PIXI
    {
        /// <summary>
        /// The ObservablePoint object represents a location in a two-dimensional coordinate system, where x represents the position on the horizontal axis and y represents the position on the vertical axis.<br/>
        /// An ObservablePoint is a point that triggers a callback when the point's position is changed.<br/>
        /// https://api.pixijs.io/@pixi/math/PIXI/ObservablePoint.html<br/>
        /// https://pixijs.download/release/docs/maths.ObservablePoint.html
        /// </summary>
        public class ObservablePoint : PointLike
        {

            #region Constructors
            /// <inheritdoc/>
            public ObservablePoint(IJSInProcessObjectReference _ref) : base(_ref) { }
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public ObservablePoint() : base(JS.New("PIXI.ObservablePoint")) { }
            /// <summary>
            /// Creates a new instance
            /// </summary>
            /// <param name="observer">Observer to pass to listen for change events.</param>
            /// <param name="x">position of the point on the x axis</param>
            /// <param name="y">position of the point on the y axis</param>
            public ObservablePoint(Observer<ObservablePoint> observer, float x = 0, float y = 0) : base(JS.New("PIXI.ObservablePoint", observer, x, y)) { }
            #endregion

            /// <summary>
            /// Creates a clone of this point
            /// </summary>
            /// <returns></returns>
            public Point Clone() => JSRef!.Call<Point>("clone");
            /// <summary>
            /// Creates a clone of this point
            /// </summary>
            /// <returns></returns>
            public Point Clone(Observer<ObservablePoint> observer) => JSRef!.Call<Point>("clone", observer);
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
