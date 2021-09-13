using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace FirstTest
{
    [Dependency(ReplaceServices = true)]
    public class FirstTestBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "FirstTest";
    }
}
