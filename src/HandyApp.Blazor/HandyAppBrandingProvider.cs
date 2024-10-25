using Microsoft.Extensions.Localization;
using HandyApp.Localization;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace HandyApp.Blazor;

[Dependency(ReplaceServices = true)]
public class HandyAppBrandingProvider : DefaultBrandingProvider
{
    private IStringLocalizer<HandyAppResource> _localizer;

    public HandyAppBrandingProvider(IStringLocalizer<HandyAppResource> localizer)
    {
        _localizer = localizer;
    }

    public override string AppName => _localizer["AppName"];
}
