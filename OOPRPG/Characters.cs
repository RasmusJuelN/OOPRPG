namespace OOPRPG
{

    // Enum with character types (sets fighter value to 1, instead of default 0)
    enum CharacterType { Fighter = 1, Mage, Cleric, Bard, Rouge, Paladin, Barbarian }

    // Class for Characters different stuff
    internal class Characters
    {
        public int Level { get; set; }
        public int Xp { get; set; }
        public string? Name { get; set; }
        public CharacterType CharacterType { get; set; }
        public Attributes? attribute { get; set; }


    }


}
