using System.Reflection;

namespace SpawnDev.BlazorJS.PixiJS.Demo.Layout
{
    public class MainLayoutService
    {
        public string DefaultTitle { get; set; } = Assembly.GetExecutingAssembly().GetName().Name!;
        public string Title
        {
            get => string.IsNullOrEmpty(_Title) ? DefaultTitle : _Title;
            set
            {
                if (_Title == value) return;
                _Title = value;
                OnTitleChanged?.Invoke();
            }
        }
        string _Title { get; set; } = "SpawnDev.BlazorJS.PixiJS";
        public delegate void AfterRender(MainLayout mainLayout, bool firstRender);
        public event AfterRender? OnAfterRender;
        public event Action? OnTitleChanged;
        public void TriggerOnAfterRender(MainLayout mainLayout, bool firstRender)
        {
            OnAfterRender?.Invoke(mainLayout, firstRender);
        }
    }
}
