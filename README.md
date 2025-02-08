# Outer Wilds Language Swap

An Outer Wilds mod to switch the current language in-game by pressing Ctrl+L

This is a very "dumb" mod that ultimately does nothing more than [call the game's internal `TextTranslation.SetLanguage()` method](https://github.com/Ixrec/OuterWildsLanguageSwap/blob/be5d9f0f0e891766d9b537403f4d2cd4bddcd34c/LanguageSwap/LanguageSwap.cs#L52). In particular, many parts of the game (e.g. most UI button prompts) will *not* be re-translated, and the re/un-loading of fonts can even cause some of that text to disappear or change size. But in testing it does seem to cause Nomai text, NPC conversations, and even many in-game textures to change language on the fly (though you may have to e.g. restart the conversation to see it).

Apparently this is also incompatible with VanillaFix (and therefore Quantum Space Buddies and all NewHorizons-based mods) because [one of the things VanillaFix fixes](https://github.com/JohnCorby/ow-vanilla-fix?tab=readme-ov-file#fixes) is "Prevents SetLanguage from being called when it shouldn't be, fixing several mods."

The two languages it swaps between can be configured in the in-game menus. The keybind to actually switch cannot be changed.
