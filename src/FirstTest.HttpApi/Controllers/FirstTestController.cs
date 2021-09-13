using FirstTest.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace FirstTest.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class FirstTestController : AbpController
    {
        protected FirstTestController()
        {
            LocalizationResource = typeof(FirstTestResource);
        }
    }
}