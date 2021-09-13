using FirstTest.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace FirstTest.Permissions
{
    public class FirstTestPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(FirstTestPermissions.GroupName);
            //Define your own permissions here. Example:
            //myGroup.AddPermission(FirstTestPermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<FirstTestResource>(name);
        }
    }
}
