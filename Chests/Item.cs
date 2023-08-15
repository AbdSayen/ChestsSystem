namespace Chests
{
    internal class Item
    {
        public string name;
        public float price;
        public Rarity rarity;
        public Item(string name, float price, Rarity rarity)
        {
            this.name = name;
            this.price = price;
            this.rarity = rarity;
        }
    
        public string GetInfo()
        {
            return $"{name} - Rarity: {rarity}; Price: {price}.";
        }
    }

    public enum Rarity
    {
        common = 70,
        rare = 50,
        epic = 30
    }
}