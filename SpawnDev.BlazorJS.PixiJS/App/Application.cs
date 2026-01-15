using Microsoft.JSInterop;
using SpawnDev.BlazorJS.JSObjects;
using System.Text.Json.Serialization;

namespace SpawnDev.BlazorJS.PixiJS
{
    public static partial class PIXI
    {
        /// <summary>
        /// https://pixijs.download/release/docs/rendering.AutoDetectOptions.html
        /// </summary>
        public class AutoDetectOptions : RendererOptions
        {
            /// <summary>
            /// The preferred renderer type. WebGPU is recommended as its generally faster than WebGL.
            /// </summary>
            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
            public string? Preference { get; set; }
            /// <summary>
            /// Optional WebGLOptions to pass only to the WebGL renderer
            /// </summary>
            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
            [JsonPropertyName("webgl")]
            public WebGLOptions? WebGL { get; set; }
            /// <summary>
            /// Optional WebGPUOptions to pass only to WebGPU renderer.
            /// </summary>
            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
            [JsonPropertyName("webgpu")]
            public WebGPUOptions? WebGPU { get; set; }
        }
        /// <summary>
        /// Convenience class to create a new PixiJS application.<br/>
        /// This class automatically creates the renderer, ticker and root container.<br/>
        /// https://api.pixijs.io/@pixi/app/PIXI/Application.html
        /// </summary>
        public class Application : JSObject
        {
            #region Constructors
            /// <summary>
            /// Deserialization constructor
            /// </summary>
            /// <param name="_ref"></param>
            public Application(IJSInProcessObjectReference _ref) : base(_ref) { }
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public Application() : base(JS.New("PIXI.Application")) { }
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public Application(ApplicationOptions options) : base(JS.New("PIXI.Application", options)) { }
            #endregion
            #region Properties
            /// <summary>
            /// Reference to the renderer's canvas element.
            /// </summary>
            public HTMLCanvasElement Canvas => JSRef!.Get<HTMLCanvasElement>("canvas");
            /// <summary>
            /// Reference to the renderer's screen rectangle. Its safe to use as `filterArea` or `hitArea` for the whole screen.
            /// </summary>
            public Rectangle Screen => JSRef!.Get<Rectangle>("screen");

            public Ticker Ticker => JSRef!.Get<Ticker>("ticker");
            /// <summary>
            /// The renderer used by this application.
            /// </summary>
            public AbstractRenderer Renderer => JSRef!.Get<AbstractRenderer>("renderer");
            /// <summary>
            /// The root display container that's rendered.
            /// </summary>
            /// <summary>
            /// The root display container that's rendered.
            /// </summary>
            public Container? Stage { get => JSRef!.Get<Container>("stage"); set => JSRef!.Set("stage", value); }
            /// <summary>
            /// The HTML element or window to automatically resize the renderer's view element to match width and height.
            /// </summary>
            public JSObject? ResizeTo { get => JSRef!.Get<JSObject?>("resizeTo"); set => JSRef!.Set("resizeTo", value); }
            #endregion
            #region Methods
            /// <summary>
            /// Initializes the Application instance
            /// </summary>
            /// <returns></returns>
            public Task Init() => JSRef!.CallVoidAsync("init");
            /// <summary>
            /// Initializes the Application instance
            /// </summary>
            /// <param name="options"></param>
            /// <returns></returns>
            public Task Init(ApplicationOptions options) => JSRef!.CallVoidAsync("init", options);
            /// <summary>
            /// Execute an immediate resize on the renderer, this is not throttled and can be expensive to call many times in a row. Will resize only if `resizeTo` property is set.
            /// </summary>
            public void Resize() => JSRef!.CallVoid("resize");
            /// <summary>
            /// Resize is throttled, so it's safe to call this multiple times per frame and it'll only be called once.
            /// </summary>
            public void QueueResize() => JSRef!.CallVoid("queueResize");
            /// <summary>
            /// Cancel the resize queue.
            /// </summary>
            public void CancelResize() => JSRef!.CallVoid("cancelResize");
            /// <summary>
            /// Clean up the ticker, scoped to application
            /// </summary>
            public void Destroy() => JSRef!.CallVoid("destroy");
            public void Stop() => JSRef!.CallVoid("stop");
            public void Start() => JSRef!.CallVoid("start");
            #endregion
            #region Events

            #endregion
        }
    }
}
