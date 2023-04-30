namespace SWE_3313_Project
{
    internal class MenuItem
    {
        String name;
        String category;
        public double price;
        private int inventory;
        private int timesOrdered;

        public MenuItem(String name, double price, String category)
        {
            this.price = price;
            this.name = name;
            this.category = category;
            inventory = 100;
            timesOrdered = 0;
        }

        public String getName() { return name; }
        public void decrementInventory()
        {
            inventory--;
        }
        public void incrementTimesOrdered()
        {
            timesOrdered++;
        }
    }
}
