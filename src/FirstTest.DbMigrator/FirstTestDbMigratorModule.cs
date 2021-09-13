using FirstTest.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace FirstTest.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(FirstTestEntityFrameworkCoreModule),
        typeof(FirstTestApplicationContractsModule)
        )]
    public class FirstTestDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
