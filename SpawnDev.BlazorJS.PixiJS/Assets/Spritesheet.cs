using Microsoft.JSInterop;
using SpawnDev.BlazorJS.IJSInProcessObjectReferenceAnyKey;
using SpawnDev.BlazorJS.JSObjects;
using System.Collections;
using static SpawnDev.BlazorJS.PixiJS.PIXI;

namespace SpawnDev.BlazorJS.PixiJS
{
    /// <summary>
    /// Utility class for maintaining reference to a collection of textures on a single SpriteSheet.
    /// </summary>
    public class Spritesheet : JSObject
    {
        /// <inheritdoc/>
        public Spritesheet(IJSInProcessObjectReference _ref) : base(_ref) { }

        /// <summary>
        /// The resolution of the spritesheet.
        /// </summary>
        public float Resolution { get => JSRef!.Get<float>("resolution"); set => JSRef!.Set("resolution", value); }

        /// <summary>
        /// The textures generated for the spritesheet.
        /// </summary>
        public Record<string, Texture> Textures { get => JSRef!.Get<Record<string, Texture>>("textures"); }

        /// <summary>
        /// The animations generated for the spritesheet.
        /// </summary>
        public Record<string, Texture[]> Animations { get => JSRef!.Get<Record<string, Texture[]>>("animations"); }

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

        /// <summary>
        /// Creates a new Spritesheet instance.
        /// </summary>
        /// <param name="texture">The source texture.</param>
        /// <param name="data">The sprite sheet data.</param>
        public Spritesheet(Texture texture, object data) : base(JS.New("PIXI.Spritesheet", texture, data)) { }
    }
}
