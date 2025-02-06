using BlazorWASM.Client;
using BlazorWASM.Client.Extensions;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Syncfusion.Blazor;
using System.Globalization;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
//Add required initialization option for localizing the Scheduler component (Syncfusion)
builder.Services.AddSingleton(typeof(ISyncfusionStringLocalizer), typeof(SyncfusionLocalizer));

CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("es");
CultureInfo.DefaultThreadCurrentUICulture = new CultureInfo("es");

//Add Syncfusion Blazor Components
builder.Services.AddSyncfusionBlazor();
builder.Services.AddSingleton(typeof(ISyncfusionStringLocalizer), typeof(SyncfusionLocalizer));
//Register Syncfusion license https://help.syncfusion.com/common/essential-studio/licensing/how-to-generate
Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("MzcwNjg0NkAzMjM4MmUzMDJlMzBDaTVBdDk2SGZSZnMvVnl0d1hnT1JEQnpNVjV0dThqNWlhT3NRWEFYVGhzPQ==");

await builder.Build().RunAsync();
