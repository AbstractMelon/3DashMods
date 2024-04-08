using BepInEx;
using HarmonyLib;
using UnityEngine;
using System.Reflection;

namespace NauseaTitle
{
    [BepInPlugin("com.Melon.NauseaTitle", "Nausea Title", "1.0.0")]
    public class NauseaTitle : BaseUnityPlugin
    {
        void Awake()
        {
            Harmony harmony = new Harmony("com.Melon.NauseaTitle");
            harmony.PatchAll(Assembly.GetExecutingAssembly());
        }
    }

    [HarmonyPatch(typeof(TitleCamera))]
    [HarmonyPatch("Update")]
    public class TitleCamera_Update_Patch
    {
        static void Postfix(TitleCamera __instance)
        {
            if (__instance != null)
            {
                __instance.rotateSpd = 100000f;
            }
        }
    }
}
