namespace Space_Expedition
{
    class FileManager
    {
        public static Artifact[] ReadArtifacts(string fileName)
        {
            Artifact[] artifacts = new Artifact[0];
            try
            {
                if(!File.Exists(fileName))
                {
                    Console.WriteLine("File not found.");
                    return artifacts;
                }
                string[] lines = File.ReadAllLines(fileName);

                foreach(string line in lines)
                {
                    //to skip empty lines
                    if(string.IsNullOrWhiteSpace(line))
                    {
                        continue;
                    }
                    string[] parts = line.Split(',');

                    if (parts.Length != 5)
                    {
                        Console.WriteLine("Invalid line skipped.");
                        continue;
                    }
                }
            }
        }
    }
}
