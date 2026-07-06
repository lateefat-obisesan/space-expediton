using Space_Expedition;

namespace space_expedition
{
    class Program
    {
        static void Main(string[] args)
        {
            string initialFile = "galactic_vault.txt";
            string outputFile = "expedition_summary.txt";

            Console.WriteLine("Loading Galactic Vault inventory.");
            Artifact[] inventory = FileManager.ReadArtifacts(initialFile);

            InventoryManager.SortInventory(inventory);
            Console.WriteLine($"Successfully loaded and sorted {inventory.Length} artifacts.\n");

            bool running = true;
            while (running)
            {
                Console.WriteLine("WELCOME TO");
                Console.WriteLine("GALACTIC VAULT MENU");
                Console.WriteLine("1. Add New Artifact Log");
                Console.WriteLine("2. View Sorted Inventory");
                Console.WriteLine("3. Save and Exit");
                Console.WriteLine("Select an option (1-3): ");

                string choice = Console.ReadLine();
                Console.WriteLine()
            }
        }
    }
}
