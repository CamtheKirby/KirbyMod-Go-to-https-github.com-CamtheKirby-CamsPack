using BTD_Mod_Helper;
using KirbyMod;
using MelonLoader;
using BTD_Mod_Helper.Api.Display;
using Il2CppAssets.Scripts.Unity.Display;

[assembly: MelonInfo(typeof(KirbyMod.KirbyMod), ModHelperData.Name, ModHelperData.Version, ModHelperData.RepoOwner)]
[assembly: MelonGame("Ninja Kiwi", "BloonsTD6")]

namespace KirbyMod;

public class KirbyMod : BloonsTD6Mod
{
    public override void OnApplicationStart()
    {
        ModHelper.Msg<KirbyMod>("OMG IT'S KIRBY TIME!");
    }
}

    
    
