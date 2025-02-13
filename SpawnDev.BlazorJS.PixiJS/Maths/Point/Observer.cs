using System.Text.Json.Serialization;

namespace SpawnDev.BlazorJS.PixiJS
{
    public static partial class PIXI
    {
        /// <summary>
        /// Observer used to listen for observable point changes.<br/>
        /// https://pixijs.download/release/docs/maths.Observer.html
        /// </summary>
        /// <typeparam name="TObserved"></typeparam>
        public class Observer<TObserved> : IDisposable
        {
            /// <summary>
            /// Callback to call when the point has updated.
            /// </summary>
            [JsonPropertyName("_onUpdate")]
            public ActionCallback<TObserved> OnUpdate { get; private set; }
            /// <summary>
            /// Create instance
            /// </summary>
            /// <param name="callback"></param>
            public Observer(Action<TObserved> callback)
            {
                OnUpdate = new ActionCallback<TObserved>(callback);
            }
            /// <summary>
            /// Create instance
            /// </summary>
            /// <param name="callback"></param>
            public Observer(ActionCallback<TObserved> callback)
            {
                OnUpdate = callback;
            }
            /// <inheritdoc/>
            public void Dispose()
            {
                OnUpdate.Dispose();
            }
        }
    }
}
