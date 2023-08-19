namespace Chests
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Inventory inventory = new Inventory();

            while (true)
            {
                int choiceId;
                Console.WriteLine("\n1 - View inventory\n2 - Find chests\n");
                int.TryParse(Console.ReadKey().KeyChar.ToString(), out choiceId);

                Console.Clear();
                switch (choiceId)
                {
                    case 1:
                        inventory.ViewInventory(true);
                        break;
                    case 2:
                        SelectChest(inventory, GenerateChests(3));
                        break;
                    default:
                        continue;
                }
            }

            List<Chest> GenerateChests(int count)
            {
                List<Chest> chests = new List<Chest>();

                for (int i = 0; i < count; i++)
                {
                    Chest chest = new Chest();
                    chests.Add(chest);
                }

                return chests;
            }

            void SelectChest(Inventory recipient, List<Chest> currentChests)
            {
                int selectedChestId = 0;

                Console.WriteLine($"\nThere are {currentChests.Count} chests with valuables in front of you. Enter the number of the chest you want to open\n");
                while (true)
                {
                    int.TryParse(Console.ReadKey().KeyChar.ToString(), out selectedChestId);

                    if (selectedChestId <= 0 || selectedChestId >= currentChests.Count + 1)
                    {
                        Console.Clear();
                        Console.WriteLine($"\nYou entered a number outside the range 1-{currentChests.Count}. Please re-enter");
                    }
                    else break;
                }

                Console.Clear();
                recipient.AddItems(currentChests[selectedChestId - 1].GetContent());
                Console.WriteLine("\nThe items have been moved to your inventory. Items:\n");
                foreach (var item in Inventory.StackItems(currentChests[selectedChestId - 1].GetContent()))
                {
                    Console.WriteLine(item.GetInfo());
                }
            }
        }
    }
}