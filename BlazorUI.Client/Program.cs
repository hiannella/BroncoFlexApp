using BlazorUI.Client.Components;
using BlazorUI.Client.Components.Layout;
using Bold.Licensing;
using Syncfusion.Blazor;
using Syncfusion.Licensing;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddMemoryCache();

//Add Syncfusion Blazor Components
builder.Services.AddSyncfusionBlazor();
//Configure Syncfusion localization options
builder.Services.AddSingleton<ISyncfusionStringLocalizer, SyncfusionLocalizer>();
var localizationOptions = new RequestLocalizationOptions()
    .SetDefaultCulture("es")
    .AddSupportedCultures("es")
    .AddSupportedUICultures("es");
//Register Syncfusion license
SyncfusionLicenseProvider.RegisterLicense("MzcwNjg0NkAzMjM4MmUzMDJlMzBDaTVBdDk2SGZSZnMvVnl0d1hnT1JEQnpNVjV0dThqNWlhT3NRWEFYVGhzPQ==");
//Register Bold license
BoldLicenseProvider.RegisterLicense("ua3Qt2jAX3gUpPzFwRRFHumBUb+LfkxpqJK7BNpXMTo=");

builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

var app = builder.Build();

// Configure the HTTP request pipeline.
//Use RequestLocalization middleware to set the culture of the request
app.UseRequestLocalization(localizationOptions);

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseAntiforgery();
//app.MapStaticAssets();
app.UseStaticFiles();
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();
app.MapControllers();
app.Run();
