namespace Chests
{
    internal class Chest
    {
        private Item[] possibleItems = {
            new Item("Experience", 0, Rarity.common, 1),
            new Item("Coin", 10, Rarity.common, 1),
            new Item("Life Potion", 25, Rarity.rare, 1),
            new Item("Mana Potion", 35, Rarity.rare, 1),
            new Item("Ring", 75, Rarity.epic, 1),   
            new Item("Sword", 100, Rarity.epic, 1),
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