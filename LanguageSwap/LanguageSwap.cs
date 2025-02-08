using HarmonyLib;
using OWML.Common;
using OWML.ModHelper;
using System;
using System.Reflection;
using UnityEngine.InputSystem;

namespace LanguageSwap
{
    public class LanguageSwap : ModBehaviour
    {
        public static LanguageSwap Instance;

        public void Awake()
        {
            Instance = this;
            // You won't be able to access OWML's mod helper in Awake.
            // So you probably don't want to do anything here.
            // Use Start() instead.
        }

        public void Start()
        {
            // Starting here, you'll have access to OWML's mod helper.
            ModHelper.Console.WriteLine($"My mod {nameof(LanguageSwap)} is loaded!", MessageType.Success);

            new Harmony("Ixrec.LanguageSwap").PatchAll(Assembly.GetExecutingAssembly());
        }

        public void Update()
        {
            var justPressedL = Keyboard.current[Key.L].wasPressedThisFrame;
            var ctrlIsDown = Keyboard.current[Key.LeftCtrl].isPressed || Keyboard.current[Key.RightCtrl].isPressed;
            if (justPressedL && ctrlIsDown)
            {
                ModHelper.Console.WriteLine("pressed Ctrl+L");

                var language1Setting = ModHelper.Config.GetSettingsValue<string>("Language 1");
                var language2Setting = ModHelper.Config.GetSettingsValue<string>("Language 2");

                Enum.TryParse(language1Setting, out TextTranslation.Language lang1);
                Enum.TryParse(language2Setting, out TextTranslation.Language lang2);

                var currentLanguage = TextTranslation.s_theTable.GetLanguage();

                ModHelper.Console.WriteLine($"current settings are language 1 = {lang1} and language 2 = {lang2}, and the game's current language is {currentLanguage}");

                var newLanguage = (currentLanguage == lang1) ? lang2 : lang1;

                ModHelper.Console.WriteLine($"switching language from {currentLanguage} to {newLanguage}");

                TextTranslation.s_theTable.SetLanguage(newLanguage);
            }
        }
    }

}
