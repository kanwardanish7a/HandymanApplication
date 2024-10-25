using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace HandyApp.Data;

/* This is used if database provider does't define
 * IHandyAppDbSchemaMigrator implementation.
 */
public class NullHandyAppDbSchemaMigrator : IHandyAppDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
