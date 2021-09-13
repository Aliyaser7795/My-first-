using System.Threading.Tasks;

namespace FirstTest.Data
{
    public interface IFirstTestDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
