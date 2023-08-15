namespace Chests
{
    internal class Inventory
    {
        private List<Item> inventory = new List<Item>();

        public void ViewInventory()
        {
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
    }
}
