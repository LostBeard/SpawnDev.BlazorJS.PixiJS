namespace SpawnDev.BlazorJS.PixiJS.Demo.Layout.AppTray
{
    public class AppTrayService
    {
        List<AppTrayIcon> _TrayIcons { get; } = new List<AppTrayIcon>();
        public IEnumerable<AppTrayIcon> TrayIcons => ReverseOrder ? _TrayIcons.AsReadOnly().Reverse() : _TrayIcons.AsReadOnly();
        public event Action? OnStateHasChanged;
        public bool ReverseOrder { get; set; } = true;
        public AppTrayService()
        {

        }
        public void Add(AppTrayIcon trayIcon)
        {
            _TrayIcons.Add(trayIcon);
            StateHasChanged();
        }
        public void Remove(AppTrayIcon trayIcon)
        {
            _TrayIcons.Remove(trayIcon);
            StateHasChanged();
        }
        public void StateHasChanged()
        {
            OnStateHasChanged?.Invoke();
        }
    }
}
