namespace Chests
{
    internal class Item
    {
        public string name;
        public float price;
        public Rarity rarity;
        public int count;
        public Item(string name, float price, Rarity rarity, int count)
        {
            this.name = name;
            this.price = price;
            this.rarity = rarity;
            this.count = count;
        }
    
        public string GetInfo()
        {
            return $"{count}X {name} - Rarity: {rarity}; Price: {price}.";
        }
    }

    public enum Rarity
    {
        common = 70,
        rare = 50,
        epic = 30
    }
}