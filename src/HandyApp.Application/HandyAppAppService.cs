using HandyApp.Localization;
using Volo.Abp.Application.Services;

namespace HandyApp;

/* Inherit your application services from this class.
 */
public abstract class HandyAppAppService : ApplicationService
{
    protected HandyAppAppService()
    {
        LocalizationResource = typeof(HandyAppResource);
    }
}
