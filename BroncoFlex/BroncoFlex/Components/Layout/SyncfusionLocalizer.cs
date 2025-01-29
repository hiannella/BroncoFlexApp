using Syncfusion.Blazor;
using System.Resources;
using BroncoFlex.Resources;

namespace BroncoFlex.Components.Layout;

public class SyncfusionLocalizer : ISyncfusionStringLocalizer
{
    // To get the locale key from mapped resources file

    public string? GetText(string key)
    {
        return ResourceManager.GetString(key);
    }

    // To access the resource file and get the exact value for locale key

    public ResourceManager ResourceManager
    {
        get
        {
            return SfResources.ResourceManager;
        }
    }
}