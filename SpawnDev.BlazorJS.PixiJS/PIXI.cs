using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpawnDev.BlazorJS.PixiJS
{
    // https://cdn.jsdelivr.net/npm/pixi.js@8.x/dist/pixi.min.js
    // https://pixijs.download/release/docs/index.html
    public static partial class PIXI
    {
        static BlazorJSRuntime JS => BlazorJSRuntime.JS;
        static Task? _Init = null;
        public static Task Init()
        {
            _Init ??= JS.LoadScript("_content/SpawnDev.BlazorJS.PixiJS/pixi.min.js", "PIXI");
            return _Init;
        }
    }
}
