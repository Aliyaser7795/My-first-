using Volo.Abp.Settings;

namespace FirstTest.Settings
{
    public class FirstTestSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(FirstTestSettings.MySetting1));
        }
    }
}
