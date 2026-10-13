// === SHOPPING LIST ===
// 1. Add Item
// 2. List Items
// 3. Mark Item Purchased
// 4. Exit
//
// Enter your choice:
class ShoppingItem
{
    public string name { get; set; } 
    public bool IsPurchased { get; set; }
    public void PurchasedItem()
    {
        IsPurchased = true;
        
    }
}
class shoppingList
{
    public List<ShoppingItem> Item { get; set; }= new List<ShoppingItem>();

    public void AddItem(ShoppingItem shope)
    {
        Item.Add(shope);
        
    }

    public void RemoveItem(ShoppingItem shope1)
    {
        Item.Remove(shope1);
    }
}
class Program
{
    static void Main(String[] args)
    { shoppingList shopList = new shoppingList();
        ShoppingItem shopItem = new ShoppingItem();
        ShoppingItem shopItem1 = new ShoppingItem();
        shopItem.name = "milk";
        shopItem1.name = "bun";
        shopList.AddItem(shopItem);
        shopList.AddItem(shopItem1);
        Console.WriteLine("=== SHOPPING LIST ===");
        Console.WriteLine("1.AddItem\n2.ListItem\n3.Mark Item Purchased \n4.Exit");     
       

        while (true)
        {
            Console.WriteLine("Enter your Choice:");
            int choice = Convert.ToInt32(Console.ReadLine());
            if (choice == 1)
            {
                ShoppingItem ItemName = new ShoppingItem();
                Console.WriteLine("Enter a Task:");
                string newTask = Console.ReadLine();
                ItemName.name = newTask;
                shopList.AddItem(ItemName);

            }
            if (choice == 2)
            {
                foreach (ShoppingItem shopitem in shopList.Item)
                {
                    Console.WriteLine($"{shopitem.name}");
                }
            }

            if (choice == 3)
            {
                Console.WriteLine("Mark Item purchased");
                string purchasedItem = Console.ReadLine();
               
            }

            if (choice == 4)
            {
                break;
            }

            Console.WriteLine(shopList.Item.Count);
        }
    }
}