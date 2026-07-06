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
                Console.WriteLine();

                switch (choice)
                {
                    case "1":
                        AddNewArtifactOption(ref inventory);
                        break;

                    case "2":
                        ViewInventoryOption(inventory);
                        break;

                    case "3":
                        // Save the updated inventory on user exit
                        Console.WriteLine("Saving inventory updates to summary log...");
                        FileManager.SaveArtifacts(outputFile, inventory);
                        Console.WriteLine("Save complete. Goodbye, Explorer!");
                        running = false;
                        break;

                    default:
                        Console.WriteLine("Invalid option. Please choose 1, 2, or 3.");
                        break;
                }

                Console.WriteLine(); // Extra space between loops
            }
        }
    }
}
