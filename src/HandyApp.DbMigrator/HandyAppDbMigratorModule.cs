using HandyApp.MongoDB;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace HandyApp.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(HandyAppMongoDbModule),
    typeof(HandyAppApplicationContractsModule)
)]
public class HandyAppDbMigratorModule : AbpModule
{
}
