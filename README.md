# SpawnDev.BlazorJS.PixiJS

[![NuGet](https://img.shields.io/nuget/dt/SpawnDev.BlazorJS.PixiJS.svg?label=SpawnDev.BlazorJS.PixiJS)](https://www.nuget.org/packages/SpawnDev.BlazorJS.PixiJS) 

**SpawnDev.BlazorJS.PixiJS** brings the amazing [PixiJS](https://github.com/pixijs/pixijs) library to Blazor WebAssembly.

The HTML5 Creation Engine: Create beautiful digital content with the fastest, most flexible 2D WebGL renderer in Blazor WebAssembly.

### Demo
[Examples Demo](https://lostbeard.github.io/SpawnDev.BlazorJS.PixiJS/)

### Getting started

Add the Nuget package `SpawnDev.BlazorJS.PixiJS` to your project using your package manager of choice.

Modify the Blazor WASM `Program.cs` to initialize SpawnDev.BlazorJS for Javascript interop.  
Example Program.cs   
```cs
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.PixiJS;
using SpawnDev.BlazorJS.PixiJS.Demo;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");
// Add SpawnDev.BlazorJS interop
builder.Services.AddBlazorJSRuntime();
// Load the PixiJS Javascript library. Can be called in a component instead if desired, or loaded using a <script> tag in the index.html
await PixiJS.Init();
// Run app using BlazorJSRunAsync extension method
await builder.Build().BlazorJSRunAsync();
```

**ContainerExample.razor**  
Source: [Basic Container Example](https://pixijs.com/8.x/examples/basic/container)  
```cs
@page "/examples/basic/container"
@using SpawnDev.BlazorJS.JSObjects
@using static SpawnDev.BlazorJS.PixiJS.PIXI
@using SpawnDev.BlazorJS.PixiJS.PIXI
@using SpawnDev.BlazorJS.JsonConverters
@implements IDisposable

<p>
    Source: <a href="https://pixijs.com/8.x/examples/basic/container">Basic Container Example</a>
</p>
<div style="width: 400px; height: 400px;" @ref="containerElRef"></div>
@code {
    [Inject]
    BlazorJSRuntime JS { get; set; }
    ElementReference? containerElRef = null;
    Application? app = null;
    Container? container = null;
    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender)
        {
            await Init();
        }
    }
    async Task Init()
    {
        using var document = JS.GetDocument<Document>();

        // Create a new application
        app = new Application();

        // Initialize the application
        await app.Init(new ApplicationOptions { Background = "#1099bb", ResizeTo = containerElRef });

        // Append the application canvas to the document body
        using var htmlElement = new HTMLElement(containerElRef!.Value);
        htmlElement!.AppendChild(app.Canvas);

        // Create and add a container to the stage
        container = new Container();
        using var stage = app.Stage;
        stage!.AddChild(container);

        // Load the bunny texture
        using var texture = await Assets.Load<Texture>("https://pixijs.com/assets/bunny.png");

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
```