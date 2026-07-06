using System.Security.Cryptography.X509Certificates;

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
        public static int BinarySearch(Artifact[] arifacts, string targetDecodedName)
        {
            int low = 0;
            int high = artifacts.Length - 1;

            while(low <= high)
            {
                int mid = low + (high - low) / 2;
                int compareResult = string.Comapare(artifacts[mid].DecodedName, targetDecodedName);
                if (compareResult == 0)
                {
                    return mid; // the artifact found, then returns its index
                }
                else if (compareResult < 0)
                {
                    low = mid + 1; // Search the right half
                }
                else
                {
                    high = mid - 1; // Search the left half
                }
                return -1;
            }
            Public static Artifact[] InsertInOrder(Artifact[] oldArray, Artifact newArtifact)
            {
                Artifact[] newArray = new Artifact[oldArray.Length + 1];
                int i = 0;

                // Copy all elements smaller than the new artifact
                while (i < oldArray.Length && string.Compare(oldArray[i].DecodedName, newArtifact.DecodedName) < 0)
                {
                    newArray[i] = oldArray[i];
                    i++;
                }
                newArray[i] = newArtifact;
                while (i < oldArray.Length)
                {
                    newArray[i + 1] = oldArray[i];
                    i++;
                }

                return newArray;
            }
        }
    }
}
