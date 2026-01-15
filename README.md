# SpawnDev.BlazorJS.PixiJS

[![NuGet](https://img.shields.io/nuget/dt/SpawnDev.BlazorJS.PixiJS.svg?label=SpawnDev.BlazorJS.PixiJS)](https://www.nuget.org/packages/SpawnDev.BlazorJS.PixiJS) 

**SpawnDev.BlazorJS.PixiJS** is a strongly-typed .NET wrapper for the [PixiJS](https://github.com/pixijs/pixijs) library (v8), bringing the functionality of the "HTML5 Creation Engine" to Blazor WebAssembly.

Create beautiful digital content with the fastest, most flexible 2D WebGL renderer directly in C#.

### Demo
[Examples Demo](https://lostbeard.github.io/SpawnDev.BlazorJS.PixiJS/)

### Getting started

#### 1. Installation
Add the Nuget package `SpawnDev.BlazorJS.PixiJS` to your project using your package manager of choice.

```bash
dotnet add package SpawnDev.BlazorJS.PixiJS
```

#### 2. Configuration
Modify the Blazor WASM `Program.cs` to initialize `SpawnDev.BlazorJS` and load the PixiJS library.

**Program.cs**
```cs
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.PixiJS;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

// Add SpawnDev.BlazorJS interop
builder.Services.AddBlazorJSRuntime();

// Initialize PixiJS. This loads the PixiJS Javascript library.
// It can also be called in a component, or you can manually add the script to index.html.
await PIXI.Init();

// Run app using BlazorJSRunAsync extension method
await builder.Build().BlazorJSRunAsync();
```

> **Note:** `PIXI.Init()` loads the bundled `pixi.min.js` from `_content/SpawnDev.BlazorJS.PixiJS/pixi.min.js`.

### Usage

Here is a comprehensive example of how to create a simple PixiJS application component in Blazor.

**ContainerExample.razor**  
Based on: [Basic Container Example](https://pixijs.com/8.x/examples/basic/container)

```razor
@page "/examples/basic/container"
@using SpawnDev.BlazorJS.JSObjects
@using SpawnDev.BlazorJS.PixiJS
@using static SpawnDev.BlazorJS.PixiJS.PIXI
@implements IDisposable

<h3>Basic Container Example</h3>

<div style="width: 400px; height: 400px;" @ref="containerElRef"></div>

@code {
    [Inject]
    BlazorJSRuntime JS { get; set; } = default!;

    ElementReference? containerElRef;
    Application? app;
    Container? container;

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender)
        {
            await Init();
        }
    }

    async Task Init()
    {
        // Ensure PIXI is initialized (safe to call multiple times)
        await PIXI.Init();

        // Create a new application
        app = new Application();

        // Initialize the application with options
        await app.Init(new ApplicationOptions 
        { 
            Background = "#1099bb", 
            ResizeTo = containerElRef 
        });

        // Append the application canvas to the container element
        using var htmlElement = new HTMLElement(containerElRef!.Value);
        htmlElement.AppendChild(app.Canvas);

        // Create and add a container to the stage
        container = new Container();
        app.Stage.AddChild(container);

        // Load the bunny texture
        using var texture = await Assets.Load<Texture>("https://pixijs.com/assets/bunny.png");

        // Create a 5x5 grid of bunnies
        for (var i = 0; i < 25; i++)
        {
            using var bunny = new Sprite(texture);
            bunny.X = (i % 5f) * 40f;
            bunny.Y = (float)Math.Floor(i / 5f) * 40f;
            container.AddChild(bunny);
        }

        // Center the container
        container.X = app.Screen.Width / 2;
        container.Y = app.Screen.Height / 2;

        // Center the pivot point
        container.Pivot.X = container.Width / 2;
        container.Pivot.Y = container.Height / 2;

        // Add a ticker for animation
        app.Ticker.Add(Tick);
    }

    void Tick(Ticker time)
    {
        if (container != null && !container.IsDisposed)
        {
            // Rotate the container
            container.Rotation -= 0.01f * time.DeltaTime;
        }
    }

    public void Dispose()
    {
        // Clean up resources
        if (app != null)
        {
            app.Ticker.Remove(Tick);
            app.Dispose();
        }
        container?.Dispose();
    }
}
```

### Features

*   **Full PixiJS v8 Support**: Targets the latest major version of PixiJS.
*   **Strongly Typed**: Enjoy intellisense and compile-time checking for PixiJS APIs.
*   **Blazor Friendly**: Designed to work seamlessly with Blazor WebAssembly.
*   **No Build Steps**: Works directly with `SpawnDev.BlazorJS` without complex JS build pipelines.

### Links

*   [NuGet Package](https://www.nuget.org/packages/SpawnDev.BlazorJS.PixiJS)
*   [PixiJS Documentation](https://pixijs.com/)
*   [SpawnDev.BlazorJS](https://github.com/LostBeard/SpawnDev.BlazorJS)