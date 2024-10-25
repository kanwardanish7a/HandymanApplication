using Volo.Abp.Modularity;

namespace HandyApp;

public abstract class HandyAppApplicationTestBase<TStartupModule> : HandyAppTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
