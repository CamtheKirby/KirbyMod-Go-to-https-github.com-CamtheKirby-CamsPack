using MelonLoader;
using BTD_Mod_Helper;
using KirbyMod;

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

