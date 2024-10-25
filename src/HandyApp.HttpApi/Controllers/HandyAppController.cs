using HandyApp.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace HandyApp.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class HandyAppController : AbpControllerBase
{
    protected HandyAppController()
    {
        LocalizationResource = typeof(HandyAppResource);
    }
}
