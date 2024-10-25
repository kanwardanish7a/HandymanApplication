using System.Threading.Tasks;

namespace HandyApp.Data;

public interface IHandyAppDbSchemaMigrator
{
    Task MigrateAsync();
}
