using System.Threading.Tasks;
using HandyApp.Localization;
using HandyApp.Permissions;
using HandyApp.MultiTenancy;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.UI.Navigation;
using Volo.Abp.SettingManagement.Blazor.Menus;
using Volo.Abp.TenantManagement.Blazor.Navigation;
using Volo.Abp.Identity.Blazor;

namespace HandyApp.Blazor.Menus
{
    public class HandyAppMenuContributor : IMenuContributor
    {
        public async Task ConfigureMenuAsync(MenuConfigurationContext context)
        {
            if (context.Menu.Name == StandardMenus.Main)
            {
                await ConfigureMainMenuAsync(context);
            }
        }

        private Task ConfigureMainMenuAsync(MenuConfigurationContext context)
        {
            var l = context.GetLocalizer<HandyAppResource>();

            // Home menu item
            context.Menu.Items.Insert(
                0,
                new ApplicationMenuItem(
                    HandyAppMenus.Home,
                    l["Menu:Home"],
                    "/",
                    icon: "fas fa-home",
                    order: 1
                )
            );

            // Add Buyer, Seller, and Service menu items under the main menu
            context.Menu.AddItem(
                new ApplicationMenuItem(
                    "HandyApp",
                    l["HandyApp"],
                    icon: "fa fa-home"
                ).AddItem(
                    new ApplicationMenuItem(
                        "HandyApp.Buyer",
                        l["Buyer"],
                        url: "/buyer",
                        icon: "fa fa-user"
                    )
                ).AddItem(
                    new ApplicationMenuItem(
                        "HandyApp.Seller",
                        l["Seller"],
                        url: "/seller",
                        icon: "fa fa-user-tie"
                    )
                ).AddItem(
                    new ApplicationMenuItem(
                        "HandyApp.Service",
                        l["Service"],
                        url: "/service",
                        icon: "fa fa-cogs"
                    )
                )
            );

            // Administration
            //var administration = context.Menu.GetAdministration();
            //administration.Order = 4;

            //if (MultiTenancyConsts.IsEnabled)
            //{
            //    administration.SetSubItemOrder(TenantManagementMenuNames.GroupName, 1);
            //}
            //else
            //{
            //    administration.TryRemoveMenuItem(TenantManagementMenuNames.GroupName);
            //}

            //administration.SetSubItemOrder(IdentityMenuNames.GroupName, 2);
            //administration.SetSubItemOrder(SettingManagementMenus.GroupName, 3);

            return Task.CompletedTask;
        }
    }
}
