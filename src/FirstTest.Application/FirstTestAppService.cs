using System;
using System.Collections.Generic;
using System.Text;
using FirstTest.Localization;
using Volo.Abp.Application.Services;

namespace FirstTest
{
    /* Inherit your application services from this class.
     */
    public abstract class FirstTestAppService : ApplicationService
    {
        protected FirstTestAppService()
        {
            LocalizationResource = typeof(FirstTestResource);
        }
    }
}
