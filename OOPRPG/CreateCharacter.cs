namespace OOPRPG
{
    internal class CreateCharacter
    {
        Attributes attributes = new();

        Data data = new();
        Characters character = new();

        // Constructor to run Menu Method on program startup
        public CreateCharacter()
        {
            while (true)
            {
                Menu();
            }
        }

        // Method to create new characters and show them
        private void Menu()
        {


            while (data.Party.Count < 4)
            {
                Console.WriteLine("Press 1 to roll attributes.");
                while (Console.ReadKey(true).Key == ConsoleKey.D1)
                {
                    Console.Clear();
                    ShowAttributes();
                    character.attribute = attributes;
                    Console.WriteLine("1. Reroll attributes.");
                    Console.WriteLine("\nSatisfied with you stats?\n2. Create Character");
                }

                Console.Write("Enter name of character: ");
                character.Name = Console.ReadLine();

                PickCharacterType();
                character.CharacterType = (CharacterType)(int)Console.ReadKey(true).Key - 48;
                Console.WriteLine("You have chosen: " + character.CharacterType + "\n");
                Console.WriteLine("3. Show character");

                if ((Console.ReadKey(true).Key == ConsoleKey.D3))
                {
                    Console.WriteLine($"\nName: {character.Name}\nCharacter Type: {character.CharacterType}\n");
                }

                Console.WriteLine("\n\nWant to Add character to party? (Y / N)");

                if ((Console.ReadKey(true).Key == ConsoleKey.Y))
                {
                    Console.WriteLine($"{character.Name} has been added to your Party");

                    data.Party.Add(character);

                }
                else if ((Console.ReadKey(true).Key == ConsoleKey.N))
                {
                    Console.WriteLine($"{character.Name} did not get added to your party");
                }

                Console.WriteLine("4. Show Party");


                if ((Console.ReadKey(true).Key == ConsoleKey.D4))
                {
                    Console.WriteLine("Your Party so far:\n ");
                    foreach (var items in data.Party)
                    {
                        Console.WriteLine($"Name: {character.Name}\nCharacter Type: {character.CharacterType}\n");
                    }
                }

            }
            Console.WriteLine("Your party is ready to set out on an adventure! Start Adventure? Y/N");
        }


        // Method to roll random attributes
        public int RollAttributes()
        {
            Random random = new Random();
            int roll = 0;

            for (int i = 0; i < 3; i++)
            {
                int dice = random.Next(1, 7);
                roll += dice;
            }
            return roll;
        }

        // Method to show rolled attributes
        public void ShowAttributes()
        {

            attributes.Strength = RollAttributes();
            Console.WriteLine($"Strenth: {attributes.Strength}");
            attributes.Charisma = RollAttributes();
            Console.WriteLine($"Charisma: {attributes.Charisma}");
            attributes.Dextrerity = RollAttributes();
            Console.WriteLine($"Dexterity: {attributes.Dextrerity}");
            attributes.Constitution = RollAttributes();
            Console.WriteLine($"Constituion: {attributes.Constitution}");
            attributes.Wisdom = RollAttributes();
            Console.WriteLine($"Wisdom: {attributes.Wisdom}");
            attributes.Intelligence = RollAttributes();
            Console.WriteLine($"Intelligence: { attributes.Intelligence}");


        }

        // Method to write out Enum Values from CharacterType in "Characters" Class
        public void PickCharacterType()
        {
            Console.WriteLine("\nSelect your character type:\n");
            foreach (var characterType in Enum.GetValues(typeof(CharacterType)))
            {

                Console.WriteLine((int)characterType + " " + characterType.ToString());
            }

        }

    }
}