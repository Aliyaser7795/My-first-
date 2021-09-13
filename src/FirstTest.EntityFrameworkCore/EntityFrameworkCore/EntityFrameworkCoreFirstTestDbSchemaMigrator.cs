using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using FirstTest.Data;
using Volo.Abp.DependencyInjection;

namespace FirstTest.EntityFrameworkCore
{
    public class EntityFrameworkCoreFirstTestDbSchemaMigrator
        : IFirstTestDbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCoreFirstTestDbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the FirstTestDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<FirstTestDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}
