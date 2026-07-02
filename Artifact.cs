namespace Space_Expedition
{
    class Artifact
    {
        public string EncodedName { get; set; }
        public string DecodedName { get; set; }
        public string Planet { get; set; }
        public string DiscoveryDate { get; set; }
        public string StorageLocation { get; set; }
        public string Description { get; set; }

        public Artifact(string encodedName, string decodedName, string planet, string discoveryDate, string storageLocation, string description)
        {
            EncodedName = encodedName;
            DecodedName = decodedName;
            Planet = planet;
            DiscoveryDate = discoveryDate;
            StorageLocation = storageLocation;
            Description = description;
        }
        public override string ToString()
        {
            return $"Decoded Name: {DecodedName}" + $"Encoded Name: {EncodedName}" + $"Planet: {Planet}" + $"Discovery Date: {DiscoveryDate}" + $"Storage Location: {StorageLocation}" + $"Description: {Description}";
        }
    }
}
