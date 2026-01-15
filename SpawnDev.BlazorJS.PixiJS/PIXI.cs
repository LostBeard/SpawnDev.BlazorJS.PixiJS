namespace SpawnDev.BlazorJS.PixiJS
{
    // https://cdn.jsdelivr.net/npm/pixi.js@8.x/dist/pixi.min.js
    // https://cdn.jsdelivr.net/npm/pixijs@7.1.4/browser/index.min.js
    // https://cdn.jsdelivr.net/npm/pixijs/browser/index.min.js
    // https://pixijs.download/release/docs/index.html
    /// <summary>
    /// https://api.pixijs.io/@pixi/core/PIXI.html
    /// </summary>
    public static partial class PIXI
    {
        static BlazorJSRuntime JS => BlazorJSRuntime.JS;
        static Task? _Init = null;
        public static Task Init()
        {
            _Init ??= JS.LoadScript("_content/SpawnDev.BlazorJS.PixiJS/pixi.min.js", "PIXI");
            return _Init;
        }
        /// <summary>
        /// The version of the PixiJS library
        /// </summary>
        public static string Version => JS.Get<string>("PIXI.VERSION");
    }
}
