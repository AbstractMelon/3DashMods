using BepInEx;
using HarmonyLib;
using UnityEngine;

[BepInPlugin("com.Melon.Invincibility", "Invincibility", "1.0.0")]
public class YourPlugin : BaseUnityPlugin
{
    void Awake()
    {
        Harmony harmony = new Harmony("com.Melon.Invincibility");
        harmony.PatchAll();
    }
}

[HarmonyPatch(typeof(PlayerScript))] 
[HarmonyPatch("Die")]
class DiePatch
{
    static bool Prefix(ref bool deathOverride)
    {
        return false;
    }
}
