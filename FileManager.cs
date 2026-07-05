namespace Space_Expedition
{
    class FileManager
    {
        public static Artifact[] ReadArtifacts(string fileName)
        {
            Artifact[] artifacts = new Artifact[0];
            try
            {
                if (!File.Exists(fileName))
                {
                    Console.WriteLine("File not found.");
                    return artifacts;
                }
                string[] lines = File.ReadAllLines(fileName);

                foreach (string line in lines)
                {
                    //to skip empty lines
                    if (string.IsNullOrWhiteSpace(line))
                    {
                        continue;
                    }
                    string[] parts = line.Split(',');

                    if (parts.Length != 5)
                    {
                        Console.WriteLine("Invalid line skipped.");
                        continue;
                    }
                    Artifact artifact = new Artifact();

                    artifact.EncodedName = parts[0].Trim();
                    artifact.DecodedName = Decoder.DecodeName(artifact.EncodedName);
                    artifact.Planet = parts[1].Trim();
                    artifact.DiscoveryDate = parts[2].Trim();
                    artifact.StorageLocation = parts[3].Trim();
                    artifact.Description = parts[4].Trim();

                    Artifact[] newArray = new Artifact[artifacts.Length + 1];

                    for (int i = 0; i < artifacts.Length; i++)
                    {
                        newArray[i] = artifacts[i];
                    }

                    newArray[artifacts.Length] = artifact;

                    artifacts = newArray;
                
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error reading file: " + ex.Message);
                    }
                    return artifacts;
            }
        public static void SaveArtifacts(string fileName, Artifact[] artifacts)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(fileName))
                {
                    foreach (Artifact artifact in artifacts)
                    {
                        writer.WriteLine(
                            artifact.EncodedName + "," +
                            artifact.Planet + "," +
                            artifact.DiscoveryDate + "," +
                            artifact.StorageLocation + "," +
                            artifact.Description);
                    }
                }
                 catch (Exception ex)
            {
                Console.WriteLine("Error saving file: " + ex.Message);
            }

        }
}
