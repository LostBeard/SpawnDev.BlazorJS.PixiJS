using Microsoft.JSInterop;
using static SpawnDev.BlazorJS.PixiJS.PIXI;

namespace SpawnDev.BlazorJS.PixiJS
{
    public class Spritesheet : JSObject
    {
        public Spritesheet(IJSInProcessObjectReference _ref) : base(_ref) { }

        /// <summary>
        /// The resolution of the spritesheet.
        /// </summary>
        public float Resolution { get => JSRef!.Get<float>("resolution"); set => JSRef!.Set("resolution", value); }

        /// <summary>
        /// The textures generated for the spritesheet.
        /// </summary>
        public Dictionary<string, Texture> Textures { get => JSRef!.Get<Dictionary<string, Texture>>("textures"); }

        /// <summary>
        /// The animations generated for the spritesheet.
        /// </summary>
        public Dictionary<string, Texture[]> Animations { get => JSRef!.Get<Dictionary<string, Texture[]>>("animations"); }

        /// <summary>
        /// Reference to the source texture.
        /// </summary>
        public Texture TextureSource => JSRef!.Get<Texture>("textureSource");

        /// <summary>
        /// Parser spritesheet from loaded data. This function can be called solely on a spritesheet that has not been parsed yet.
        /// </summary>
        /// <returns></returns>
        public Task Parse() => JSRef!.CallVoidAsync("parse");

        /// <summary>
        /// Destroy this spritesheet.
        /// </summary>
        /// <param name="destroyBase">Whether to destroy the base texture as well.</param>
        public void Destroy(bool destroyBase = false) => JSRef!.CallVoid("destroy", destroyBase);

        public Spritesheet(Texture texture, object data) : base(JS.New("PIXI.Spritesheet", texture, data)) { }
    }
}
