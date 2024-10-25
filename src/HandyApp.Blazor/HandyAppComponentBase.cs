using HandyApp.Localization;
using Volo.Abp.AspNetCore.Components;

namespace HandyApp.Blazor;

public abstract class HandyAppComponentBase : AbpComponentBase
{
    protected HandyAppComponentBase()
    {
        LocalizationResource = typeof(HandyAppResource);
    }
}
