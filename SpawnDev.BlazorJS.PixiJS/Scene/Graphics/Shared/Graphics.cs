using Microsoft.JSInterop;

namespace SpawnDev.BlazorJS.PixiJS
{
    public static partial class PIXI
    {
        public class Graphics : ViewContainer
        {
            /// <inheritdoc/>
            public Graphics(IJSInProcessObjectReference _ref) : base(_ref) { }
            /// <summary>
            /// Create a new instance
            /// </summary>
            public Graphics() : base(JS.New("PIXI.Graphics")) { }
            /// <summary>
            /// Adds an arc to the current path, which is centered at (x, y) with the specified radius, starting and ending angles, and direction.
            /// </summary>
            /// <param name="x">The x-coordinate of the arc's center.</param>
            /// <param name="y">The y-coordinate of the arc's center.</param>
            /// <param name="radius">The arc's radius.</param>
            /// <param name="startAngle">The starting angle, in radians.</param>
            /// <param name="endAngle">The ending angle, in radians.</param>
            /// <param name="counterclockwise">(Optional) Specifies whether the arc is drawn counterclockwise (true) or clockwise (false). Defaults to false.</param>
            /// <returns>The instance of the current GraphicsContext for method chaining.</returns>
            public Graphics Arc(float x, float y, float radius, float startAngle, float endAngle, bool counterclockwise) { JSRef!.CallVoid("arc", x, y, radius, startAngle, endAngle, counterclockwise); return this; }
            /// <summary>
            /// Adds an arc to the current path with the given control points and radius, connected to the previous point by a straight line if necessary.
            /// </summary>
            /// <param name="x1">The x-coordinate of the first control point.</param>
            /// <param name="y1">The y-coordinate of the first control point.</param>
            /// <param name="x2">The x-coordinate of the second control point.</param>
            /// <param name="y2">The y-coordinate of the second control point.</param>
            /// <param name="radius">The arc's radius.</param>
            /// <returns></returns>
            public Graphics ArcTo(float x1, float y1, float x2, float y2, float radius) { JSRef!.CallVoid("arcTo", x1, y1, x2, y2, radius); return this; }
            /// <summary>
            /// Adds an SVG-style arc to the path, allowing for elliptical arcs based on the SVG spec.
            /// </summary>
            /// <param name="rx"></param>
            /// <param name="ry"></param>
            /// <param name="xAxisRotation"></param>
            /// <param name="largerArcFlag"></param>
            /// <param name="sweepFlag"></param>
            /// <param name="x"></param>
            /// <param name="y"></param>
            /// <returns></returns>
            public Graphics ArcToSvg(float rx, float ry, float xAxisRotation, float largerArcFlag, float sweepFlag, float x, float y) { JSRef!.CallVoid("arcToSvg", rx, ry, xAxisRotation, largerArcFlag, sweepFlag, x, y); return this; }
            /// <summary>
            /// Resets the current path. Any previous path and its commands are discarded and a new path is started. This is typically called before beginning a new shape or series of drawing commands.
            /// </summary>
            /// <returns></returns>
            public Graphics BeginPath() { JSRef!.CallVoid("beginPath"); return this; }
            /// <summary>
            /// Adds a cubic Bezier curve to the path. It requires three points: the first two are control points and the third one is the end point. The starting point is the last point in the current path.
            /// </summary>
            /// <param name="cp1x">The x-coordinate of the first control point.</param>
            /// <param name="cp1y">The y-coordinate of the first control point.</param>
            /// <param name="cp2x">The x-coordinate of the second control point.</param>
            /// <param name="cp2y">The y-coordinate of the second control point.</param>
            /// <param name="x">The x-coordinate of the end point.</param>
            /// <param name="y">The y-coordinate of the end point.</param>
            /// <param name="smoothness">Optional parameter to adjust the smoothness of the curve.</param>
            /// <returns></returns>
            public Graphics BezierCurveTo(float cp1x, float cp1y, float cp2x, float cp2y, float x, float y, float smoothness) { JSRef!.CallVoid("bezierCurveTo", cp1x, cp1y, cp2x, cp2y, x, y, smoothness); return this; }
            /// <summary>
            /// Draw Rectangle with chamfer corners. These are angled corners.
            /// </summary>
            /// <param name="x">Upper left corner of rect</param>
            /// <param name="y">Upper right corner of rect</param>
            /// <param name="width">Width of rect</param>
            /// <param name="height">Height of rect</param>
            /// <param name="chamfer">non-zero real number, size of corner cutout</param>
            /// <param name="transform"></param>
            /// <returns></returns>
            public Graphics ChamferRect(float x, float y, float width, float height, float chamfer, Matrix transform) { JSRef!.CallVoid("chamferRect", x, y, width, height, chamfer, transform); return this; }
            /// <summary>
            /// Draw Rectangle with chamfer corners. These are angled corners.
            /// </summary>
            /// <param name="x">Upper left corner of rect</param>
            /// <param name="y">Upper right corner of rect</param>
            /// <param name="width">Width of rect</param>
            /// <param name="height">Height of rect</param>
            /// <param name="chamfer">non-zero real number, size of corner cutout</param>
            /// <returns></returns>
            public Graphics ChamferRect(float x, float y, float width, float height, float chamfer) { JSRef!.CallVoid("chamferRect", x, y, width, height, chamfer); return this; }
            /// <summary>
            /// Draws a circle shape. This method adds a new circle path to the current drawing.
            /// </summary>
            /// <param name="x">The x-coordinate of the center of the circle.</param>
            /// <param name="y">The y-coordinate of the center of the circle.</param>
            /// <param name="radius">The radius of the circle.</param>
            /// <returns></returns>
            public Graphics Circle(float x, float y, float radius) { JSRef!.CallVoid("circle", x, y, radius); return this; }
            /// <summary>
            /// Clears all drawing commands from the graphics context, effectively resetting it. This includes clearing the path, and optionally resetting transformations to the identity matrix.
            /// </summary>
            /// <returns></returns>
            public Graphics Clear() { JSRef!.CallVoid("clear"); return this; }
            /// <summary>
            /// Creates a new Graphics object. Note that only the context of the object is cloned, not its transform (position,scale,etc)
            /// </summary>
            /// <param name="deep">Whether to create a deep clone of the graphics object. If false, the context will be shared between the two objects (default false). If true, the context will be cloned (recommended if you need to modify the context in any way).</param>
            /// <returns></returns>
            public Graphics Clone(bool deep = false) => JSRef!.Call<Graphics>("clone", deep);
            /// <summary>
            /// Closes the current path by drawing a straight line back to the start. If the shape is already closed or there are no points in the path, this method does nothing.
            /// </summary>
            /// <returns></returns>
            public Graphics ClosePath() { JSRef!.CallVoid("closePath"); return this; }
            /// <summary>
            /// Applies a cutout to the last drawn shape. This is used to create holes or complex shapes by subtracting a path from the previously drawn path. If a hole is not completely in a shape, it will fail to cut correctly!
            /// </summary>
            /// <returns></returns>
            public Graphics Cut() { JSRef!.CallVoid("cut"); return this; }
            /// <summary>
            /// Destroys this graphics renderable and optionally its context.
            /// </summary>
            /// <returns></returns>
            public void Destroy() => JSRef!.CallVoid("destroy");
            /// <summary>
            /// Draws an ellipse at the specified location and with the given x and y radii. An optional transformation can be applied, allowing for rotation, scaling, and translation.
            /// </summary>
            /// <param name="x"></param>
            /// <param name="y"></param>
            /// <param name="radiusX"></param>
            /// <param name="radiusY"></param>
            /// <returns></returns>
            public Graphics Ellipse(float x, float y, float radiusX, float radiusY) { JSRef!.CallVoid("ellipse", x, y, radiusX, radiusY); return this; }
            /// <summary>
            /// Fills the current or given path with the current fill style. This method can optionally take a color and alpha for a simple fill, or a more complex FillStyle object for advanced fills.
            /// </summary>
            /// <param name="style"></param>
            /// <returns></returns>
            public Graphics Fill(FillStyle style) { JSRef!.CallVoid("fill", style); return this; }
            /// <summary>
            /// Fills the current or given path with the current fill style. This method can optionally take a color and alpha for a simple fill, or a more complex FillStyle object for advanced fills.
            /// </summary>
            /// <param name="color"></param>
            /// <param name="alpha"></param>
            public Graphics Fill(ColorSource color, float alpha = 1) { JSRef!.CallVoid("fill", color, alpha); return this; }
            /// <summary>
            /// Draw Rectangle with fillet corners. This is much like rounded rectangle however it support negative numbers as well for the corner radius.
            /// </summary>
            /// <param name="x"></param>
            /// <param name="y"></param>
            /// <param name="width"></param>
            /// <param name="height"></param>
            /// <param name="fillet"></param>
            /// <returns></returns>
            public Graphics FilletRect(float x, float y, float width, float height, float fillet) { JSRef!.CallVoid("filletRect", x, y, width, height, fillet); return this; }
            /// <summary>
            /// Returns the current transformation matrix of the graphics context.
            /// </summary>
            /// <returns></returns>
            public Matrix GetTransform() => JSRef!.Call<Matrix>("getTransform");
            /// <summary>
            /// Connects the current point to a new point with a straight line. This method updates the current path.
            /// </summary>
            /// <param name="x"></param>
            /// <param name="y"></param>
            /// <returns></returns>
            public Graphics LineTo(float x, float y) { JSRef!.CallVoid("lineTo", x, y); return this; }
            /// <summary>
            /// Sets the starting point for a new sub-path. Any subsequent drawing commands are considered part of this path.
            /// </summary>
            /// <param name="x"></param>
            /// <param name="y"></param>
            /// <returns></returns>
            public Graphics MoveTo(float x, float y) { JSRef!.CallVoid("moveTo", x, y); return this; }
            /// <summary>
            /// Adds another GraphicsPath to this path, optionally applying a transformation.
            /// </summary>
            /// <param name="path">The GraphicsPath to add.</param>
            /// <returns></returns>
            public Graphics Path(GraphicsPath path) { JSRef!.CallVoid("path", path); return this; }
            /// <summary>
            /// Draws a polygon shape by specifying a sequence of points. This method allows for the creation of complex polygons, which can be both open and closed. An optional transformation can be applied, enabling the polygon to be scaled, rotated, or translated as needed.
            /// </summary>
            /// <param name="points">An array of numbers, or an array of PointData objects eg [{x,y}, {x,y}, {x,y}] representing the x and y coordinates, of the polygon's vertices, in sequence.</param>
            /// <param name="close">A boolean indicating whether to close the polygon path. True by default.</param>
            /// <returns></returns>
            public Graphics Poly(IEnumerable<IPointData> points, bool close = true) { JSRef!.CallVoid("poly", points, close); return this; }
            /// <summary>
            /// Draws a polygon shape by specifying a sequence of points. This method allows for the creation of complex polygons, which can be both open and closed. An optional transformation can be applied, enabling the polygon to be scaled, rotated, or translated as needed.
            /// </summary>
            /// <param name="points">An array of numbers, or an array of PointData objects eg [{x,y}, {x,y}, {x,y}] representing the x and y coordinates, of the polygon's vertices, in sequence.</param>
            /// <param name="close">A boolean indicating whether to close the polygon path. True by default.</param>
            /// <returns></returns>
            public Graphics Poly(IEnumerable<float> points, bool close = true) { JSRef!.CallVoid("poly", points, close); return this; }
            /// <summary>
            /// Draws a polygon shape by specifying a sequence of points. This method allows for the creation of complex polygons, which can be both open and closed. An optional transformation can be applied, enabling the polygon to be scaled, rotated, or translated as needed.
            /// </summary>
            /// <param name="points">An array of numbers, or an array of PointData objects eg [{x,y}, {x,y}, {x,y}] representing the x and y coordinates, of the polygon's vertices, in sequence.</param>
            /// <param name="close">A boolean indicating whether to close the polygon path. True by default.</param>
            /// <returns></returns>
            public Graphics Poly(IEnumerable<int> points, bool close = true) { JSRef!.CallVoid("poly", points, close); return this; }
            /// <summary>
            /// Adds a quadratic curve to the path. It requires two points: the control point and the end point. The starting point is the last point in the current path.
            /// </summary>
            /// <param name="cpx">The x-coordinate of the control point.</param>
            /// <param name="cpy">The y-coordinate of the control point.</param>
            /// <param name="x">The x-coordinate of the end point.</param>
            /// <param name="y">The y-coordinate of the end point.</param>
            /// <param name="smoothness">Optional parameter to adjust the smoothness of the curve.</param>
            /// <returns></returns>
            public Graphics QuadraticCurveTo(float cpx, float cpy, float x, float y, float smoothness) { JSRef!.CallVoid("quadraticCurveTo", cpx, cpy, x, y, smoothness); return this; }
            /// <summary>
            /// Adds a quadratic curve to the path. It requires two points: the control point and the end point. The starting point is the last point in the current path.
            /// </summary>
            /// <param name="cpx">The x-coordinate of the control point.</param>
            /// <param name="cpy">The y-coordinate of the control point.</param>
            /// <param name="x">The x-coordinate of the end point.</param>
            /// <param name="y">The y-coordinate of the end point.</param>
            /// <returns></returns>
            public Graphics QuadraticCurveTo(float cpx, float cpy, float x, float y) { JSRef!.CallVoid("quadraticCurveTo", cpx, cpy, x, y); return this; }
            /// <summary>
            /// Draws a rectangle shape. This method adds a new rectangle path to the current drawing.
            /// </summary>
            /// <param name="x"></param>
            /// <param name="y"></param>
            /// <param name="width"></param>
            /// <param name="height"></param>
            public Graphics Rect(float x, float y, float width, float height) { JSRef!.CallVoid("rect", x, y, width, height); return this; }
            /// <summary>
            /// Draws a regular polygon with a specified number of sides. All sides and angles are equal.
            /// </summary>
            /// <param name="x">The x-coordinate of the center of the polygon.</param>
            /// <param name="y">The y-coordinate of the center of the polygon.</param>
            /// <param name="radius">The radius of the circumscribed circle of the polygon.</param>
            /// <param name="sides">The number of sides of the polygon. Must be 3 or more.</param>
            /// <param name="rotation">The rotation angle of the polygon, in radians. Zero by default.</param>
            /// <param name="transform">An optional Matrix object to apply a transformation to the polygon.</param>
            /// <returns></returns>
            public Graphics RegularPoly(float x, float y, float radius, int sides, float rotation, Matrix transform) { JSRef!.CallVoid("regularPoly", x, y, radius, sides, rotation, transform); return this; }
            /// <summary>
            /// Draws a regular polygon with a specified number of sides. All sides and angles are equal.
            /// </summary>
            /// <param name="x">The x-coordinate of the center of the polygon.</param>
            /// <param name="y">The y-coordinate of the center of the polygon.</param>
            /// <param name="radius">The radius of the circumscribed circle of the polygon.</param>
            /// <param name="sides">The number of sides of the polygon. Must be 3 or more.</param>
            /// <param name="rotation">The rotation angle of the polygon, in radians. Zero by default.</param>
            /// <returns></returns>
            public Graphics RegularPoly(float x, float y, float radius, int sides, float rotation) { JSRef!.CallVoid("regularPoly", x, y, radius, sides, rotation); return this; }
            /// <summary>
            /// Resets the current transformation matrix to the identity matrix, effectively removing any transformations (rotation, scaling, translation) previously applied.
            /// </summary>
            /// <returns></returns>
            public Graphics ResetTransform() { JSRef!.CallVoid("resetTransform"); return this; }
            /// <summary>
            /// Restores the most recently saved graphics state by popping the top of the graphics state stack. This includes transformations, fill styles, and stroke styles.
            /// </summary>
            /// <returns></returns>
            public Graphics Restore() { JSRef!.CallVoid("restore"); return this; }
            /// <summary>
            /// Applies a rotation transformation to the graphics context around the current origin.
            /// </summary>
            /// <param name="angle">The angle of rotation in radians.</param>
            /// <returns></returns>
            public Graphics RotateTransform(float angle) { JSRef!.CallVoid("rotateTransform", angle); return this; }
            /// <summary>
            /// Draws a polygon with rounded corners. Similar to regularPoly but with the ability to round the corners of the polygon.
            /// </summary>
            /// <param name="x"></param>
            /// <param name="y"></param>
            /// <param name="radius"></param>
            /// <param name="sides"></param>
            /// <param name="corner"></param>
            /// <param name="rotation"></param>
            /// <returns></returns>
            public Graphics RoundPoly(float x, float y, float radius, int sides, float corner, float rotation = 0) { JSRef!.CallVoid("roundPoly", x, y, radius, sides, corner, rotation); return this; }
            /// <summary>
            /// Draws a rectangle with rounded corners. The corner radius can be specified to determine how rounded the corners should be. An optional transformation can be applied, which allows for rotation, scaling, and translation of the rectangle.
            /// </summary>
            /// <param name="x"></param>
            /// <param name="y"></param>
            /// <param name="w"></param>
            /// <param name="h"></param>
            /// <param name="radius"></param>
            public Graphics RoundRect(float x, float y, float w, float h, float radius) { JSRef!.CallVoid("roundRect", x, y, w, h, radius); return this; }
            /// <summary>
            /// Draws a shape with rounded corners. This function supports custom radius for each corner of the shape. Optionally, corners can be rounded using a quadratic curve instead of an arc, providing a different aesthetic.
            /// </summary>
            /// <param name="points">An array of RoundedPoint representing the corners of the shape to draw. A minimum of 3 points is required.</param>
            /// <param name="radius">The default radius for the corners. This radius is applied to all corners unless overridden in points.</param>
            /// <param name="useQuadratic">If set to true, rounded corners are drawn using a quadraticCurve method instead of an arc method. Defaults to false.</param>
            /// <param name="smoothness">Specifies the smoothness of the curve when useQuadratic is true. Higher values make the curve smoother.</param>
            /// <returns></returns>
            public Graphics RoundShape(IEnumerable<RoundedPoint> points, float radius, bool useQuadratic, float smoothness) { JSRef!.CallVoid("roundShape", points, radius, useQuadratic, smoothness); return this; }
            /// <summary>
            /// Saves the current graphics state, including transformations, fill styles, and stroke styles, onto a stack.
            /// </summary>
            /// <returns></returns>
            public Graphics Save() { JSRef!.CallVoid("save"); return this; }
            /// <summary>
            /// Applies a scaling transformation to the graphics context, scaling drawings by x horizontally and by y vertically.
            /// </summary>
            /// <param name="x">The scale factor in the horizontal direction.</param>
            /// <param name="y">(Optional) The scale factor in the vertical direction. If not specified, the x value is used for both directions.</param>
            /// <returns></returns>
            public Graphics ScaleTransform(float x, float y) { JSRef!.CallVoid("scaleTransform", x, y); return this; }
            /// <summary>
            /// Applies a scaling transformation to the graphics context, scaling drawings by x horizontally and by y vertically.
            /// </summary>
            /// <param name="x">The scale factor in the horizontal direction.</param>
            /// <returns></returns>
            public Graphics ScaleTransform(float x) { JSRef!.CallVoid("scaleTransform", x); return this; }
            /// <summary>
            /// Draws a star shape centered at a specified location. This method allows for the creation of stars with a variable number of points, outer radius, optional inner radius, and rotation. The star is drawn as a closed polygon with alternating outer and inner vertices to create the star's points. An optional transformation can be applied to scale, rotate, or translate the star as needed.
            /// </summary>
            /// <param name="x"></param>
            /// <param name="y"></param>
            /// <param name="points"></param>
            /// <param name="radius"></param>
            /// <returns></returns>
            public Graphics Star(float x, float y, int points, float radius) { JSRef!.CallVoid("star", x, y, points, radius); return this; }
            /// <summary>
            /// Draws a star shape centered at a specified location. This method allows for the creation of stars with a variable number of points, outer radius, optional inner radius, and rotation. The star is drawn as a closed polygon with alternating outer and inner vertices to create the star's points. An optional transformation can be applied to scale, rotate, or translate the star as needed.
            /// </summary>
            /// <param name="x"></param>
            /// <param name="y"></param>
            /// <param name="points"></param>
            /// <param name="radius"></param>
            /// <param name="innerRadius"></param>
            /// <param name="rotation"></param>
            /// <returns></returns>
            public Graphics Star(float x, float y, int points, float radius, float innerRadius, float rotation = 0) { JSRef!.CallVoid("star", x, y, points, radius, innerRadius, rotation); return this; }
            /// <summary>
            /// Strokes the current path with the current stroke style. This method can take an optional FillStyle parameter to define the stroke's appearance, including its color, width, and other properties.
            /// </summary>
            /// <param name="style"></param>
            /// <returns></returns>
            public Graphics Stroke(StrokeStyle style) { JSRef!.CallVoid("stroke", style); return this; }
        }
    }
}
