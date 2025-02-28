﻿using Microsoft.JSInterop;

namespace SpawnDev.BlazorJS.PixiJS
{
    public static partial class PIXI
    {
        static AssetsClass? _Assets = null;
        public static AssetsClass Assets => _Assets ??= JS.Get<AssetsClass>("PIXI.Assets");
        public class AssetsClass : JSObject
        {

            /// <summary>
            /// Loads your assets! You pass in a key or URL and it will return a promise that<br/>
            /// resolves to the loaded asset.If multiple assets a requested, it will return a hash of assets.<br/>
            ///<br/>
            /// Don't worry about loading things multiple times, behind the scenes assets are only ever loaded<br/>
            /// once and the same promise reused behind the scenes so you can safely call this function multiple<br/>
            /// times with the same key and it will always return the same asset.<br/>
            /// </summary>
            /// <param name="uri"></param>
            /// <param name="progressCallback"></param>
            /// <returns></returns>
            public async Task<T> Load<T>(string uri, ProgressCallbackDelegate? progressCallback = null)
            {
                using var callback = progressCallback == null ? null : new ActionCallback<float>((progress) => progressCallback(progress));
                return await JSRef!.CallAsync<T>("load", uri, callback);
            }
            /// <summary>
            /// Loads your assets! You pass in a key or URL and it will return a promise that<br/>
            /// resolves to the loaded asset.If multiple assets a requested, it will return a hash of assets.<br/>
            ///<br/>
            /// Don't worry about loading things multiple times, behind the scenes assets are only ever loaded<br/>
            /// once and the same promise reused behind the scenes so you can safely call this function multiple<br/>
            /// times with the same key and it will always return the same asset.<br/>
            /// </summary>
            /// <param name="uri"></param>
            /// <param name="progressCallback"></param>
            /// <returns></returns>
            public async Task Load(string uri, ProgressCallbackDelegate? progressCallback = null)
            {
                using var callback = progressCallback == null ? null : new ActionCallback<float>((progress) => progressCallback(progress));
                await JSRef!.CallVoidAsync("load", uri, callback);
            }
            /// <summary>
            /// Loads your assets! You pass in a key or URL and it will return a promise that<br/>
            /// resolves to the loaded asset.If multiple assets a requested, it will return a hash of assets.<br/>
            ///<br/>
            /// Don't worry about loading things multiple times, behind the scenes assets are only ever loaded<br/>
            /// once and the same promise reused behind the scenes so you can safely call this function multiple<br/>
            /// times with the same key and it will always return the same asset.<br/>
            /// </summary>
            /// <param name="uri"></param>
            /// <param name="progressCallback"></param>
            /// <returns></returns>
            public async Task<Dictionary<string, T>> Load<T>(IEnumerable<string> uri, ProgressCallbackDelegate? progressCallback = null)
            {
                using var callback = progressCallback == null ? null : new ActionCallback<float>((progress) => progressCallback(progress));
                return await JSRef!.CallAsync<Dictionary<string, T>>("load", uri, callback);
            }
            public delegate void ProgressCallbackDelegate(float progress);

            /// <summary>
            /// 
            /// </summary>
            /// <param name="bundleId"></param>
            /// <returns></returns>
            public Task LoadBundle(string bundleId)=>JSRef!.CallVoidAsync("loadBundle", bundleId);

            /// <summary>
            /// This adds a bundle of assets in one go so that you can load them as a group.
            /// </summary>
            /// <param name="bundleId"></param>
            /// <param name="assets"></param>
            public void AddBundle(string bundleId, IEnumerable<string> assets) => JSRef!.CallVoidAsync("addBundle", bundleId, assets);
            /// <summary>
            /// This adds a bundle of assets in one go so that you can load them as a group.
            /// </summary>
            /// <param name="bundleId"></param>
            /// <param name="assets"></param>
            public void AddBundle(string bundleId, IEnumerable<UnresolvedAsset> assets) => JSRef!.CallVoidAsync("addBundle", bundleId, assets);
            /// <summary>
            /// This adds a bundle of assets in one go so that you can load them as a group.
            /// </summary>
            /// <param name="bundleId"></param>
            /// <param name="asset"></param>
            public void AddBundle(string bundleId, string asset) => JSRef!.CallVoidAsync("addBundle", bundleId, asset);
            /// <summary>
            /// This adds a bundle of assets in one go so that you can load them as a group.
            /// </summary>
            /// <param name="bundleId"></param>
            /// <param name="asset"></param>
            public void AddBundle(string bundleId, UnresolvedAsset asset) => JSRef!.CallVoidAsync("addBundle", bundleId, asset);


            #region Constructors
            /// <summary>
            /// Deserialization constructor
            /// </summary>
            /// <param name="_ref"></param>
            public AssetsClass(IJSInProcessObjectReference _ref) : base(_ref) { }
            #endregion
            #region Properties

            #endregion
            #region Methods

            #endregion
            #region Events

            #endregion
        }
    }
}
