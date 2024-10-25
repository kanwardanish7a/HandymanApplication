using Volo.Abp.Modularity;

namespace HandyApp;

[DependsOn(
    typeof(HandyAppDomainModule),
    typeof(HandyAppTestBaseModule)
)]
public class HandyAppDomainTestModule : AbpModule
{

}
