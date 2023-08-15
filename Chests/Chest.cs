namespace Chests
{
    internal class Chest
    {
        private Item[] possibleItems = {
            new Item("Experience", 0, Rarity.common),
            new Item("Coin", 10, Rarity.common),
            new Item("Life Potion", 25, Rarity.rare),
            new Item("Mana Potion", 35, Rarity.rare),
            new Item("Ring", 75, Rarity.epic),
            new Item("Sword", 100, Rarity.epic),
        };

        private List<Item> content = new List<Item>();

        public Chest()
        {
            GenerateItems();
        }

        public List<Item> GetContent()
        {
            return content;
        }

        public void TakeContent(Inventory recipient)
        {
            recipient.AddItems(content);
        }

        private void GenerateItems()
        {
            Random random = new Random();
            for (int i = 0; i < possibleItems.Length; i++)
            {
                Item item = possibleItems[i];
                int count = 0;

                while (true)
                {
                    if (random.Next(0, 101) <= (float)item.rarity)
                    {
                        content.Add(item);
                    }
                    else break;
                }
            }
        }
    }
}