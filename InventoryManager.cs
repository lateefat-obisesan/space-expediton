namespace Space_Expedition
{
    class InventoryManager
    {
        public static void SortInventory(Artifact[] artifacts)
        {
            for(int i = 1; i < artifacts.Length; i++)
            {
                Artifact key = artifacts[i];
                int j = i - 1;
                while (j >= 0 && string.Compare(artifacts[j]. DecodedName, key.DecodedName) > 0)
                {
                    artifacts[j + 1] = artifacts[j];
                    j--;
                }
                artifacts[j + 1] = key;
            }
        }
        public 
    }
}
