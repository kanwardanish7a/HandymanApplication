using Volo.Abp.Modularity;

namespace HandyApp;

/* Inherit from this class for your domain layer tests. */
public abstract class HandyAppDomainTestBase<TStartupModule> : HandyAppTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
