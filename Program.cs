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
                Console.WriteLine();
            }
        }
    }
}
