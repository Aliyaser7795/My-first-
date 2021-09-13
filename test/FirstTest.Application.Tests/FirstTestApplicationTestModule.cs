using Volo.Abp.Modularity;

namespace FirstTest
{
    [DependsOn(
        typeof(FirstTestApplicationModule),
        typeof(FirstTestDomainTestModule)
        )]
    public class FirstTestApplicationTestModule : AbpModule
    {

    }
}