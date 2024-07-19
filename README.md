# SpawnDev.BlazorJS.PixiJS

[![NuGet](https://img.shields.io/nuget/dt/SpawnDev.BlazorJS.PixiJS.svg?label=SpawnDev.BlazorJS.PixiJS)](https://www.nuget.org/packages/SpawnDev.BlazorJS.PixiJS) 

**SpawnDev.BlazorJS.PixiJS** brings the amazing [PixiJS](https://github.com/pixijs/pixijs) library to Blazor WebAssembly.

The HTML5 Creation Engine: Create beautiful digital content with the fastest, most flexible 2D WebGL renderer in Blazor WebAssembly.

### Demo
[Simple Demo](https://lostbeard.github.io/SpawnDev.BlazorJS.PixiJS/)

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
