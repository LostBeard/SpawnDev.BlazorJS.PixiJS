using Microsoft.AspNetCore.Components.Web;
using Radzen;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.PixiJS.Demo.Layout.AppTray
{
    public class ThemeTrayIconService : IBackgroundService
    {
        BlazorJSRuntime JS;
        AppTrayService TrayIconService;
        Storage? LocalStorage;
        AppTrayIcon? ThemeTrayIcon;
        ThemeService ThemeService;
        ContextMenuService ContextMenuService;
        public string Theme => ThemeService.Theme;
        public bool IsDarkTheme => GetIsThemeDark(ThemeService.Theme);
        public string LightTheme => GetLightTheme(ThemeService.Theme);
        public string DarkTheme => GetDarkTheme(ThemeService.Theme);
        public string ThemeName => GetThemeName(ThemeService.Theme);
        // (LightTheme, DarkTheme, ThemeName)
        public List<(string, string, string)> Themes { get; } = new List<(string, string, string)>
        {
            ("default" , "dark", "Default"),
            ("material" , "material-dark", "Material"),
            ("software" , "software-dark", "Software"),
            ("humanistic" , "humanistic-dark", "Humanistic"),
            ("standard" , "standard-dark", "Standard"),
            // Not working with free Radzen
            //("fluent" , "fluent-dark", "Fluent"),
            //("material3" , "material3-dark", "Material 3"),
        };
        bool DefaultThemeIsDark = false;
        public ThemeTrayIconService(BlazorJSRuntime js, AppTrayService trayIconService, ContextMenuService contextMenuService, ThemeService themeService)
        {
            ContextMenuService = contextMenuService;
            ThemeService = themeService;
            JS = js;
            TrayIconService = trayIconService;
            DefaultThemeIsDark = GetIsThemeDark(ThemeService.Theme);
            if (JS.IsWindow)
            {
                using var window = JS.Get<Window>("window");
                LocalStorage = window.LocalStorage;
                // Theme icon
                ThemeTrayIcon = new AppTrayIcon
                {
                    ClickCallback = ThemeTrayIcon_ClickCallback,
                    ContextCallback = ThemeTrayIcon_ContextCallback,
                    Icon = GetThemeIcon(),
                    Visible = true,
                };
                TrayIconService.Add(ThemeTrayIcon);
                ThemeService.ThemeChanged += ThemeService_ThemeChanged;
                LoadUserTheme();
            }
            JS.Log("Current theme", ThemeService.Theme);
        }
        void SaveUserTheme()
        {
            if (LocalStorage == null) return;
            LocalStorage.SetItem("theme", ThemeService.Theme);
        }
        int GetThemeIndex(string theme)
        {
            for (var i = 0; i < Themes.Count; i++)
            {
                var themePair = Themes[i];
                if (themePair.Item1.Equals(theme, StringComparison.OrdinalIgnoreCase) || themePair.Item2.Equals(theme, StringComparison.OrdinalIgnoreCase)) return i;
            }
            return -1;
        }
        void LoadUserTheme()
        {
            if (LocalStorage == null) return;
            var theme = LocalStorage.GetItem("theme");
            if (!string.IsNullOrEmpty(theme))
            {
                ThemeService.SetTheme(theme);
            }
        }
        string GetThemeIcon() => GetIsThemeDark(ThemeService.Theme) ? "dark_mode" : "light_mode";
        bool GetIsThemeDark(string themeName) => themeName != null && (themeName.ToLowerInvariant().StartsWith("dark") || themeName.ToLowerInvariant().Contains("-dark"));
        private string GetLightTheme(string theme)
        {
            var entry = GetThemeEntry(theme) ?? Themes[0];
            return entry.Item1;
        }
        private string GetDarkTheme(string theme)
        {
            var entry = GetThemeEntry(theme) ?? Themes[0];
            return entry.Item2;
        }
        private string GetThemeName(string theme)
        {
            var entry = GetThemeEntry(theme) ?? Themes[0];
            return entry.Item3;
        }
        private (string, string, string)? GetThemeEntry(string theme)
        {
            var i = GetThemeIndex(theme);
            if (i == -1) return null;
            return Themes[i];
        }
        private void ThemeService_ThemeChanged()
        {
            SaveUserTheme();
            if (ThemeTrayIcon != null)
            {
                ThemeTrayIcon.Icon = GetThemeIcon();
                ThemeTrayIcon.Title = IsDarkTheme ? $"{ThemeName} Dark" : ThemeName;
            }
            TrayIconService.StateHasChanged();
        }
        void ThemeMenu_Click(MenuItemEventArgs args)
        {
            var entry = ((string, string, string))args.Value;
            ContextMenuService.Close();
            var theme = GetIsThemeDark(ThemeService.Theme) ? entry.Item2 : entry.Item1;
            ThemeService.SetTheme(theme);
        }
        IEnumerable<ContextMenuItem> GetThemeMenuOptions()
        {
            var menuItems = new List<ContextMenuItem>();
            foreach (var entry in Themes)
            {
                var isCurrentTheme = entry.Item1.Equals(ThemeService.Theme, StringComparison.OrdinalIgnoreCase) || entry.Item2.Equals(ThemeService.Theme, StringComparison.OrdinalIgnoreCase);
                menuItems.Add(new ContextMenuItem
                {
                    Text = entry.Item3,
                    Value = entry,
                    Icon = isCurrentTheme ? "radio_button_checked" : "radio_button_unchecked",
                });
            }
            return menuItems;
        }
        void ThemeTrayIcon_ContextCallback(MouseEventArgs mouseEventArgs)
        {
            ContextMenuService.Open(mouseEventArgs, GetThemeMenuOptions(), ThemeMenu_Click);
        }
        void ThemeTrayIcon_ClickCallback(MouseEventArgs mouseEventArgs)
        {
            if (mouseEventArgs.ShiftKey)
            {
                NextTheme(false);
            }
            else if (mouseEventArgs.CtrlKey)
            {
                NextTheme(true);
            }
            else
            {
                ToggleDark();
            }
        }
        public void NextTheme(bool reverse = false)
        {
            var theme = ThemeService.Theme?.ToLowerInvariant() ?? "";
            var isDark = GetIsThemeDark(theme);
            var themes = Themes.SelectMany(o => DefaultThemeIsDark ? new string[] { o.Item2, o.Item1 } : new string[] { o.Item1, o.Item2 }).ToList();
            var i = themes.IndexOf(theme);
            if (i == -1) i = 0;
            i += reverse ? -1 : 1;
            if (i < 0) i = themes.Count - 1;
            if (i >= themes.Count) i = 0;
            var newTheme = themes[i];
            ThemeService.SetTheme(newTheme);
        }
        public void SetDark() => ThemeService.SetTheme(DarkTheme);
        public void SetTheme(string theme) => ThemeService.SetTheme(theme);
        public void SetLight() => ThemeService.SetTheme(LightTheme);
        public void ToggleDark()
        {
            ThemeService.SetTheme(IsDarkTheme ? LightTheme : DarkTheme);
        }
    }
}
