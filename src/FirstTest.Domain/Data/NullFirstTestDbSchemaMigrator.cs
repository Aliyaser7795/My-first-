using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace FirstTest.Data
{
    /* This is used if database provider does't define
     * IFirstTestDbSchemaMigrator implementation.
     */
    public class NullFirstTestDbSchemaMigrator : IFirstTestDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}