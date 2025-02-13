using Microsoft.AspNetCore.Components;

namespace SpawnDev.BlazorJS.PixiJS.Demo.Layout.AppTray
{
    public partial class AppTrayArea : IDisposable
    {
        [Inject]
        AppTrayService TrayIconService { get; set; }

        protected override void OnInitialized()
        {
            TrayIconService.OnStateHasChanged += TrayIconService_OnStateHasChanged;

        }
        protected override void OnAfterRender(bool firstRender)
        {

        }
        public void Dispose()
        {
            TrayIconService.OnStateHasChanged -= TrayIconService_OnStateHasChanged;
        }
        private void TrayIconService_OnStateHasChanged()
        {
            StateHasChanged();
        }
    }
}
