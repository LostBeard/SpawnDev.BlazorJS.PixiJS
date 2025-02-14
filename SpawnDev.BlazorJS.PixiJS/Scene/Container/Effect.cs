using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpawnDev.BlazorJS.PixiJS
{
    /// <summary>
    /// An effect that can be applied to a container. This is used to create effects such as filters/masks etc.
    /// </summary>
    public static partial class PIXI
    {
        public interface Effect
        {
            string Pipe { get; set; }
            float Priority { get; set; }
            void Destroy();
        }
    }
}
