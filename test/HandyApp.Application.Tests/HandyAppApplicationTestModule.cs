using Volo.Abp.Modularity;

namespace HandyApp;

[DependsOn(
    typeof(HandyAppApplicationModule),
    typeof(HandyAppDomainTestModule)
)]
public class HandyAppApplicationTestModule : AbpModule
{

}
