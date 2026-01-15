using Microsoft.JSInterop;
using SpawnDev.BlazorJS.IJSInProcessObjectReferenceAnyKey;
using SpawnDev.BlazorJS.JSObjects;
using System.Collections;

namespace SpawnDev.BlazorJS.PixiJS
{
    /// <summary>
    /// An object type whose property keys are Keys and whose property values are Type. This utility can be used to map the properties of a type to another type.
    /// https://www.typescriptlang.org/docs/handbook/utility-types.html#recordkeys-type
    /// </summary>
    /// <typeparam name="TKey"></typeparam>
    /// <typeparam name="TValue"></typeparam>
    public class Record<TKey, TValue> : JSObject //, IEnumerable<(TKey Key, TValue Value)>
        where TKey : notnull
    {
        #region IEnumerable
        ///// <inheritdoc/>
        //public IEnumerator<(TKey Key, TValue Value)> GetEnumerator()
        //{
        //    var keys = Keys.Using(o => o.ToArray());
        //    var length = keys.Length;
        //    return new SimpleEnumerator<(TKey Key, TValue Value)>((i) =>
        //    {
        //        var key = keys[i];
        //        var value = this[key];
        //        return (key, value);
        //    }, () => length);
        //}
        ///// <inheritdoc/>
        //IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
        #endregion
        /// <inheritdoc/>
        public Record(IJSInProcessObjectReference _ref) : base(_ref) { }
        /// <summary>
        /// Get or set an entry value
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public TValue this[TKey index]
        {
            get => JSRef!.Get<TValue>(index);
            set => JSRef!.Set(index, value);
        }
        /// <summary>
        /// Record keys
        /// </summary>
        public Array<TKey> Keys => JS.Call<Array<TKey>>("Object.keys", JSRef);
        /// <summary>
        /// The number of entries
        /// </summary>
        public int Length => Keys.Using(o => o.Length);
        /// <summary>
        /// Remove an entry
        /// </summary>
        /// <param name="key"></param>
        public void Delete(TKey key) => JSRef!.Delete(key);
    }
}
