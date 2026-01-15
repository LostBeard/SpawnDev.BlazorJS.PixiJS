using Microsoft.JSInterop;
using SpawnDev.BlazorJS.JSObjects;
using Array = SpawnDev.BlazorJS.JSObjects.Array;

namespace SpawnDev.BlazorJS.PixiJS
{
    public static partial class PIXI
    {
        /// <summary>
        /// Container is a general-purpose display object that holds children. It also adds built-in support for advanced rendering features like masking and filtering.<br/>
        /// It is the base class of all display objects that act as a container for other objects, including Graphics and Sprite.<br/>
        /// https://pixijs.download/v8.7.1/docs/scene.Container.html
        /// </summary>
        public class Container : EventTarget
        {
            #region Constructors
            /// <summary>
            /// Deserialization constructor
            /// </summary>
            /// <param name="_ref"></param>
            public Container(IJSInProcessObjectReference _ref) : base(_ref) { }
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public Container() : base(JS.New("PIXI.Container")) { }
            #endregion
            #region Properties
            /// <summary>
            /// Flag for if the object is accessible. If true AccessibilityManager will overlay a shadow div with attributes set. Defaults to true.
            /// </summary>
            public float Accessible { get => JSRef!.Get<float>("accessible"); set => JSRef!.Set("accessible", value); }
            /// <summary>
            /// Setting to false will prevent any children inside this container to be accessible. Defaults to true.<br/>
            /// </summary>
            public float AccessibleChildren { get => JSRef!.Get<float>("accessibleChildren"); set => JSRef!.Set("accessibleChildren", value); }
            /// <summary>
            /// Sets the aria-label attribute of the shadow div
            /// </summary>
            public string? AccessibleHint { get => JSRef!.Get<string?>("accessibleHint"); set => JSRef!.Set("accessibleHint", value); }
            /// <summary>
            /// Specify the pointer-events the accessible div will use Defaults to auto.
            /// </summary>
            public string? AccessiblePointerEvents { get => JSRef!.Get<string?>("accessiblePointerEvents"); set => JSRef!.Set("accessiblePointerEvents", value); }
            /// <summary>
            /// Sets the text content of the shadow div
            /// </summary>
            public string? AccessibleText { get => JSRef!.Get<string?>("accessibleText"); set => JSRef!.Set("accessibleText", value); }
            /// <summary>
            /// Sets the title attribute of the shadow div If accessibleTitle AND accessibleHint has not been this will default to 'container [tabIndex]'
            /// </summary>
            public string? AccessibleTitle { get => JSRef!.Get<string?>("accessibleTitle"); set => JSRef!.Set("accessibleTitle", value); }
            /// <summary>
            /// Specify the type of div the accessible layer is. Screen readers treat the element differently depending on this type. Defaults to button.
            /// </summary>
            public string? AccessibleType { get => JSRef!.Get<string?>("accessibleType"); set => JSRef!.Set("accessibleType", value); }
            /// <summary>
            /// The opacity of the object.
            /// </summary>
            public float Alpha { get => JSRef!.Get<float>("alpha"); set => JSRef!.Set("alpha", value); }
            /// <summary>
            /// The angle of the object in degrees. 'rotation' and 'angle' have the same effect on a display object; rotation is in radians, angle is in degrees.
            /// </summary>
            public float Angle { get => JSRef!.Get<float>("angle"); set => JSRef!.Set("angle", value); }
            /// <summary>
            /// The blend mode to be applied to the sprite. Apply a value of 'normal' to reset the blend mode.
            /// </summary>
            public string? BlendMode { get => JSRef!.Get<string?>("blendMode"); set => JSRef!.Set("blendMode", value); }
            /// <summary>
            /// An optional bounds area for this container. Setting this rectangle will stop the renderer from recursively measuring the bounds of each children and instead use this single boundArea. This is great for optimisation! If for example you have a 1000 spinning particles and you know they all sit within a specific bounds, then setting it will mean the renderer will not need to measure the 1000 children to find the bounds. Instead it will just use the bounds you set.
            /// </summary>
            public Rectangle? BoundsArea { get => JSRef!.Get<Rectangle?>("boundsArea"); set => JSRef!.Set("boundsArea", value); }
            /// <summary>
            /// The array of children of this container.
            /// </summary>
            public Array Children => JSRef!.Get<Array>("children");
            /// <summary>
            /// Should this object be rendered if the bounds of this object are out of frame?<br/>
            /// Culling has no effect on whether updateTransform is called.
            /// </summary>
            public bool Cullable { get => JSRef!.Get<bool>("cullable"); set => JSRef!.Set("cullable", value); }
            /// <summary>
            /// Determines if the children to the container can be culled Setting this to false allows PixiJS to bypass a recursive culling function Which can help to optimize very complex scenes
            /// </summary>
            public bool CullableChildren { get => JSRef!.Get<bool>("cullableChildren"); set => JSRef!.Set("cullableChildren", value); }
            /// <summary>
            /// If set, this shape is used for culling instead of the bounds of this object. It can improve the culling performance of objects with many children. The culling area is defined in local space.
            /// </summary>
            public Rectangle? CullableArea { get => JSRef!.Get<Rectangle?>("cullableArea"); set => JSRef!.Set("cullableArea", value); }
            /// <summary>
            /// If the object has been destroyed via destroy(). If true, it should not be used.
            /// </summary>
            public bool Destroyed => JSRef!.Get<bool>("destroyed");
            /// <summary>
            /// Container effects
            /// </summary>
            public Array<Effect>? Effects { get => JSRef!.Get<Array<Effect>?>("effects"); set => JSRef!.Set("effects", value); }
            /// <summary>
            /// The group transform is a transform relative to the render group it belongs too. If this container is render group then this will be an identity matrix. other wise it will be the same as the relativeGroupTransform. Use this value when actually rendering things to the screen
            /// </summary>
            public Matrix GroupTransform => JSRef!.Get<Matrix>("groupTransform");
            /// <summary>
            /// The height of the Container, setting this will actually modify the scale to achieve the value set.
            /// </summary>
            public float Height { get => JSRef!.Get<float>("height"); set => JSRef!.Set("height", value); }
            /// <summary>
            /// Determines if the children to the container can be clicked/touched Setting this to false allows PixiJS to bypass a recursive hitTest function
            /// </summary>
            public bool InteractiveChildren { get => JSRef!.Get<bool>("interactiveChildren"); set => JSRef!.Set("interactiveChildren", value); }
            /// <summary>
            /// Whether this container is currently cached as a texture.
            /// </summary>
            public bool IsCachedAsTexture => JSRef!.Get<bool>("isCachedAsTexture");
            /// <summary>
            /// Whether or not the object should be rendered.
            /// </summary>
            public bool IsRenderable { get => JSRef!.Get<bool>("isRenderable"); set => JSRef!.Set("isRenderable", value); }
            /// <summary>
            /// Returns true if this container is a render group. This means that it will be rendered as a separate pass, with its own set of instructions
            /// </summary>
            public bool IsRenderGroup { get => JSRef!.Get<bool>("isRenderGroup"); set => JSRef!.Set("isRenderGroup", value); }
            /// <summary>
            /// The instance label of the object.
            /// </summary>
            public string? Label { get => JSRef!.Get<string?>("label"); set => JSRef!.Set("label", value); }
            /// <summary>
            /// Current transform of the object based on local factors: position, scale, other stuff.
            /// </summary>
            public Matrix LocalTransform => JSRef!.Get<Matrix>("localTransform");
            /// <summary>
            /// The display object container that contains this display object.
            /// </summary>
            public Container? Parent { get => JSRef!.Get<Container?>("parent"); set => JSRef!.Set("parent", value); }
            ///// <summary>
            ///// The RenderLayer this container belongs to, if any. If it belongs to a RenderLayer, it will be rendered from the RenderLayer's position in the scene.
            ///// </summary>
            //public IRenderLayer ParentRenderLayer => JSRef!.Get<IRenderLayer>("parentRenderLayer");
            /// <summary>
            /// The center of rotation, scaling, and skewing for this display object in its local space. The position is the projection of pivot in the parent's local space.
            /// </summary>
            public ObservablePoint Pivot { get => JSRef!.Get<ObservablePoint>("pivot"); set => JSRef!.Set("pivot", value); }
            /// <summary>
            /// The coordinate of the object relative to the local coordinates of the parent.
            /// </summary>
            public ObservablePoint Position { get => JSRef!.Get<ObservablePoint>("position"); set => JSRef!.Set("position", value); }
            /// <summary>
            /// The relative group transform is a transform relative to the render group it belongs too. It will include all parent transforms and up to the render group (think of it as kind of like a stage - but the stage can be nested). If this container is is self a render group matrix will be relative to its parent render group
            /// </summary>
            public Matrix RelativeGroupTransform => JSRef!.Get<Matrix>("relativeGroupTransform");
            /// <summary>
            /// Can this object be rendered, if false the object will not be drawn but the transform will still be updated.
            /// </summary>
            public bool Renderable { get => JSRef!.Get<bool>("renderable"); set => JSRef!.Set("renderable", value); }
            /// <summary>
            /// The rotation of the object in radians. 'rotation' and 'angle' have the same effect on a display object; rotation is in radians, angle is in degrees.
            /// </summary>
            public float Rotation { get => JSRef!.Get<float>("rotation"); set => JSRef!.Set("rotation", value); }
            /// <summary>
            /// The scale factors of this object along the local coordinate axes.<br/>
            /// The default scale is (1, 1).
            /// </summary>
            public ObservablePoint Scale { get => JSRef!.Get<ObservablePoint>("scale"); set => JSRef!.Set("scale", value); }
            /// <summary>
            /// The skew factor for the object in radians.
            /// </summary>
            public ObservablePoint Skew { get => JSRef!.Get<ObservablePoint>("skew"); set => JSRef!.Set("skew", value); }
            /// <summary>
            /// If set to true, the container will sort its children by zIndex value when the next render is called, or manually if sortChildren() is called.<br/>
            /// This actually changes the order of elements in the array, so should be treated as a basic solution that is not performant compared to other solutions, such as PixiJS Layers<br/>
            /// Also be aware of that this may not work nicely with the addChildAt() function, as the zIndex sorting may cause the child to automatically sorted to another position.
            /// </summary>
            public bool SortableChildren { get => JSRef!.Get<bool>("sortableChildren"); set => JSRef!.Set("sortableChildren", value); }
            /// <summary>
            /// Should children be sorted by zIndex at the next render call.<br/>
            /// Will get automatically set to true if a new child is added, or if a child's zIndex changes.
            /// </summary>
            public bool SortDirty { get => JSRef!.Get<bool>("sortDirty"); set => JSRef!.Set("sortDirty", value); }
            /// <summary>
            /// Tab index
            /// </summary>
            public int TabIndex { get => JSRef!.Get<int>("tabIndex"); set => JSRef!.Set("tabIndex", value); }
            /// <summary>
            /// The tint applied to the sprite. This is a hex value.
            /// </summary>
            public int Tint { get => JSRef!.Get<int>("tint"); set => JSRef!.Set("tint", value); }
            /// <summary>
            /// unique id for this container
            /// </summary>
            public long Uid => JSRef!.Get<long>("uid");
            /// <summary>
            /// The visibility of the object. If false the object will not be drawn, and the transform will not be updated.
            /// </summary>
            public bool Visible { get => JSRef!.Get<bool>("visible"); set => JSRef!.Set("visible", value); }
            /// <summary>
            /// The width of the Container, setting this will actually modify the scale to achieve the value set.
            /// </summary>
            public float Width { get => JSRef!.Get<float>("width"); set => JSRef!.Set("width", value); }
            /// <summary>
            /// Current transform of the object based on world (parent) factors.
            /// </summary>
            public Matrix WorldTransform => JSRef!.Get<Matrix>("worldTransform");
            /// <summary>
            /// The position of the container on the x axis relative to the local coordinates of the parent. An alias to position.x
            /// </summary>
            public float X { get => JSRef!.Get<float>("x"); set => JSRef!.Set("x", value); }
            /// <summary>
            /// The position of the container on the y axis relative to the local coordinates of the parent. An alias to position.y
            /// </summary>
            public float Y { get => JSRef!.Get<float>("y"); set => JSRef!.Set("y", value); }
            /// <summary>
            /// The zIndex of the displayObject.
            /// </summary>
            public int ZIndex { get => JSRef!.Get<int>("zIndex"); set => JSRef!.Set("zIndex", value); }

            /// <summary>
            /// Sets the filters for the displayObject.
            /// * IMPORTANT: This is a pass-through property that sets/gets the filter array. 
            /// * Getting it returns a NEW array reference from JS. Modifying that array won't affect the container unless you assign it back.
            /// </summary>
            public Filter[]? Filters { get => JSRef!.Get<Filter[]?>("filters"); set => JSRef!.Set("filters", value); }

            /// <summary>
            /// Interaction shape. Children will be hit first, then this shape will be checked.
            /// </summary>
            public string? Cursor { get => JSRef!.Get<string?>("cursor"); set => JSRef!.Set("cursor", value); }
            /// <summary>
            /// Enable interaction events for the Container. Touch, pointer, etc.
            /// </summary>
            public string? EventMode { get => JSRef!.Get<string?>("eventMode"); set => JSRef!.Set("eventMode", value); }
            /// <summary>
            /// Whether the container is interactive. Deprecated in favor of EventMode.
            /// </summary>
            public bool Interactive { get => JSRef!.Get<bool>("interactive"); set => JSRef!.Set("interactive", value); }
            #endregion
            #region Methods
            /// <summary>
            /// Adds one or more children to the container.
            /// </summary>
            public void AddChild(params Container[] children) => JSRef!.CallApplyVoid("addChild", children);
            /// <summary>
            /// Removes one or more children from the container.
            /// </summary>
            public void RemoveChild(params Container[] children) => JSRef!.CallApplyVoid("removeChild", children);
            /// <summary>
            /// Removes all children from this container that are within the begin and end indexes.
            /// </summary>
            public void RemoveChildren(int beginIndex = 0, int endIndex = -1)
            {
                if (endIndex == -1) JSRef!.CallVoid("removeChildren", beginIndex);
                else JSRef!.CallVoid("removeChildren", beginIndex, endIndex);
            }
            /// <summary>
            /// Returns the child at the specified index
            /// </summary>
            public Container GetChildAt(int index) => JSRef!.Call<Container>("getChildAt", index);
            /// <summary>
            /// Returns the index position of a child DisplayObject instance
            /// </summary>
            public int GetChildIndex(Container child) => JSRef!.Call<int>("getChildIndex", child);
            /// <summary>
            /// Changes the position of an existing child in the display object container
            /// </summary>
            public void SetChildIndex(Container child, int index) => JSRef!.CallVoid("setChildIndex", child, index);
            /// <summary>
            /// Swaps the position of 2 Display Objects within this container.
            /// </summary>
            public void SwapChildren(Container child, Container child2) => JSRef!.CallVoid("swapChildren", child, child2);
            /// <summary>
            /// Calculates the global position of the display object
            /// </summary>
            public Point ToGlobal(Point position, Point? point = null, bool? skipUpdate = null) => JSRef!.Call<Point>("toGlobal", position, point, skipUpdate);
            /// <summary>
            /// Calculates the local position of the display object relative to another point
            /// </summary>
            public Point ToLocal(Point position, Container? from = null, Point? point = null, bool? skipUpdate = null) => JSRef!.Call<Point>("toLocal", position, from, point, skipUpdate);
            #endregion
            #region Events
            /// <summary>
            /// Adds an event listener
            /// </summary>
            public void On(string eventName, Action callback) => JSRef!.CallVoid("on", eventName, callback);
            /// <summary>
            /// Adds an event listener
            /// </summary>
            public void On<T>(string eventName, Action<T> callback) => JSRef!.CallVoid("on", eventName, callback);
            /// <summary>
            /// Removes an event listener
            /// </summary>
            public void Off(string eventName, Action callback) => JSRef!.CallVoid("off", eventName, callback);
            /// <summary>
            /// Removes an event listener
            /// </summary>
            public void Off<T>(string eventName, Action<T> callback) => JSRef!.CallVoid("off", eventName, callback);
            #endregion
        }
    }
}
