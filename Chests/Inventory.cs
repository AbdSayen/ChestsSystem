namespace Chests
{
    internal class Inventory
    {
        private List<Item> inventory = new List<Item>();

        public void ViewInventory(bool isStacked)
        {
            if (isStacked)
                foreach (var item in StackItems(inventory))
                {
                    Console.WriteLine(item.GetInfo());
                }
            else
                foreach (var item in inventory)
                {
                    Console.WriteLine(item.GetInfo());
                }
        }

        public List<Item> GetItems()
        {
            return inventory;
        }

        public void AddItem(Item item)
        {
            inventory.Add(item);
        }

        public void AddItems(List<Item> items)
        {
            foreach (var item in items)
            {
                inventory.Add(item);
            }
        }

        public static List<Item> StackItems(List<Item> items)
        {
            Dictionary<string, int> itemCounts = new Dictionary<string, int>();
            List<Item> updatedItems = new List<Item>();

            foreach (Item item in items)
            {
                if (itemCounts.ContainsKey(item.name))
                {
                    itemCounts[item.name]++;
                }
                else
                {
                    itemCounts[item.name] = 1;
                    updatedItems.Add(item);
                }
            }

            foreach (Item updatedItem in updatedItems)
            {
                updatedItem.count = itemCounts[updatedItem.name];
            }

            return updatedItems;
        }
    }
}
