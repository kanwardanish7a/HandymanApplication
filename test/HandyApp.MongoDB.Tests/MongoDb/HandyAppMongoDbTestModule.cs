using System;
using Volo.Abp.Data;
using Volo.Abp.Modularity;
using Volo.Abp.Uow;

namespace HandyApp.MongoDB;

[DependsOn(
    typeof(HandyAppApplicationTestModule),
    typeof(HandyAppMongoDbModule)
)]
public class HandyAppMongoDbTestModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpDbConnectionOptions>(options =>
        {
            options.ConnectionStrings.Default = HandyAppMongoDbFixture.GetRandomConnectionString();
        });
    }
}
