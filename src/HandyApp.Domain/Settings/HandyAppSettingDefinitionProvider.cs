using Volo.Abp.Settings;

namespace HandyApp.Settings;

public class HandyAppSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(HandyAppSettings.MySetting1));
    }
}
