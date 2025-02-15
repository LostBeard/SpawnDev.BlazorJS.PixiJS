using BlazorMonaco.Editor;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using SpawnDev.BlazorJS.CodeRunner;

namespace SpawnDev.BlazorJS.PixiJS.Demo.Pages
{
    public partial class Playground
    {
        [Inject]
        BlazorJSRuntime JS { get; set; }

        [Inject]
        CompilationService CompilationService { get; set; } = default!;

        Type? CompiledType = null;

        StandaloneCodeEditor _Editor;

        string _textarea = @"@using System
@using System.Threading.Tasks
@using Microsoft.AspNetCore.Components
@using Microsoft.AspNetCore.Components.Rendering
@using SpawnDev.BlazorJS
@using SpawnDev.BlazorJS.JSObjects
@using static SpawnDev.BlazorJS.PixiJS.PIXI
@using SpawnDev.BlazorJS.JsonConverters
@implements IDisposable

<div class=""container"">
    <div style=""width: 400px; height: 400px;"" id=""@_id""></div>
</div>
@code {
    [Inject]
    BlazorJSRuntime JS { get; set; }
    Application? app = null;
    Container? container = null;
    bool _beenInit = false;
    string _id = Guid.NewGuid().ToString();
    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (!_beenInit)
        {
            _beenInit = true;
            await Init();
        }
    }
    async Task Init()
    {
        using var document = JS.GetDocument();

        // Create a new application
        app = new Application();

        // Append the application canvas to the document body
        using var htmlElement = document.GetElementById<HTMLDivElement>(_id);

        // Initialize the application
        await app.Init(new ApplicationOptions
            {
                Antialias = true,
                BackgroundColor = ""white"",
                ResizeTo = htmlElement
            });

        htmlElement!.AppendChild(app.Canvas);

        // Create and add a container to the stage
        container = new Container();
        using var stage = app.Stage;
        stage!.AddChild(container);

        // Load the bunny texture
        using var texture = await Assets.Load<Texture>(""https://pixijs.com/assets/bunny.png"");

        // Create a 5x5 grid of bunnies in the container
        for (var i = 0; i < 25; i++)
        {
            using var bunny = new Sprite(texture);

            bunny.X = (i % 5f) * 40f;
            bunny.Y = (float)Math.Floor(i / 5f) * 40f;
            container.AddChild(bunny);
        }

        // Move the container to the center
        container.X = app.Screen.Width / 2;
        container.Y = app.Screen.Height / 2;

        // Center the bunny sprites in local container coordinates
        container.Pivot.X = container.Width / 2;
        container.Pivot.Y = container.Height / 2;

        // Listen for animate update
        using var ticker = app.Ticker;
        ticker.Add(Tick);
    }
    void Tick(Ticker time)
    {
        // Continuously rotate the container!
        // * use delta to create frame-independent transform *
        container!.Rotation -= 0.01f * time.DeltaTime;
    }
    public void Dispose()
    {
        if (app != null)
        {
            using var ticker = app.Ticker;
            ticker.Remove(Tick);
            app.Dispose();
        }
        container?.Dispose();
    }
}


";
        bool _busy = false;
        private StandaloneEditorConstructionOptions EditorConstructionOptions(StandaloneCodeEditor editor)
        {
            return new StandaloneEditorConstructionOptions
            {
                AutomaticLayout = true,
                Language = "csharp",
                Value = _textarea,
                Theme = "vs-dark",
            };
        }

        List<string> CompileLog = new List<string>();
        bool _compileFailed = false;
        async Task CompileAndRun()
        {
            CompiledType = null;
            if (_busy) return;
            CompileLog.Clear();
            _compileFailed = false;
            try
            {
                _busy = true;
                StateHasChanged();
                _textarea = await _Editor.GetValue();
                CompiledType = await CompilationService.CompileRazorCodeToBlazorComponentType(_textarea, async msg =>
                {
                    JS.Log($"Compiler: {msg}");
                    CompileLog.Add(msg);
                    StateHasChanged();
                    await Task.Delay(100);
                });
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
            finally
            {
                _compileFailed = CompiledType == null;
                _busy = false;
            }
            StateHasChanged();
        }
    }
}
