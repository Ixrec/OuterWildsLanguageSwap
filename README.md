# Outer Wilds Language Swap

An Outer Wilds mod to switch the current language in-game by pressing Ctrl+L

This is a very "dumb" mod that ultimately does nothing more than call the game's internal `TextTranslation.SetLanguage()` method. In particular, many parts of the game (e.g. most UI button prompts) will *not* be re-translated, and the re/un-loading of fonts can even cause some of that text to disappear. But in testing it does seem to cause nomai text, NPC conversations, and even many in-game textures to change language on the fly (though you may have to e.g. restart the conversation to see it).

The two languages it swaps between can be configured in the in-game menus. The keybind to actually switch cannot be changed.
