namespace Task_2
{
    public struct Price
    {
        private string name;
        private string shop;
        private int cost;
        
        public Price(string name , string shop, int cost)
        {
            this.name = name;
            this.cost = cost;
            this.shop = shop;
        }

        public string Name
        {
            get { return name; }
        }

        public string Shop
        {
            get { return shop; }
        }

        public int Cost
        {
            get { return cost; }
        } 

    }
}