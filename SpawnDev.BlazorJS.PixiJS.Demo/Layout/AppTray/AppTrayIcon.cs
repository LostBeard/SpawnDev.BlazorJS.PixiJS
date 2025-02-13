using Microsoft.AspNetCore.Components.Web;
using Radzen;

namespace SpawnDev.BlazorJS.PixiJS.Demo.Layout.AppTray
{
    public class AppTrayIcon
    {
        public string TLText { get; set; } = "";
        public string Title { get; set; } = "";
        public string Style { get; set; } = "";
        public string Icon { get; set; } = "";
        public Action<MouseEventArgs> ClickCallback { get; set; } = new Action<MouseEventArgs>((args) => { });
        public Action<MouseEventArgs> ContextCallback { get; set; } = new Action<MouseEventArgs>((args) => { });
        public IconStyle? IconStyle { get; set; }
        public bool Visible { get; set; } = true;
    }
}
