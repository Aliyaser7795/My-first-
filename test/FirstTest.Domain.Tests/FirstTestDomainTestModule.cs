using FirstTest.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace FirstTest
{
    [DependsOn(
        typeof(FirstTestEntityFrameworkCoreTestModule)
        )]
    public class FirstTestDomainTestModule : AbpModule
    {

    }
}