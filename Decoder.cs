namespace Space_Expedition
{
    class Decoder
    {
        private static readonly char[] originalLetters =
        {
            'A','B','C','D','E','F','G','H','I','J','K','L','M',
            'N','O','P','Q','R','S','T','U','V','W','X','Y','Z'
        };

        private static readonly char[] mappedLetters =
       {
            'H','Z','A','U','Y','E','K','G','O','T','I','R','J',
            'V','W','N','M','F','Q','S','D','B','X','L','C','P'
       };
        public static string DecodeName(string encodedName)
        {
            string[] parts = encodedName.Split('|');
            string decodedName = " ";
            for (int i = 0; i < parts.Length; i++)
            {
                string token = parts[i].Trim();

                if (token.Length < 2)
                {
                    continue;
                }

                char letter = token[0];
                int level = int.Parse(token.Substring(1));

                decodedName += DecodeToken(letter, level);
            }
            return decodedName;
        }
        private static char DecodeToken(char letter, int level)
        {
            if (level == 1)
            {
                return MirrorLetter(letter);
            }
            char mappedLetter = GetMappedLetter(letter);
            return DecodeToken(mappedLetter, level - 1);
        }
        private static char GetMappedLetter(char letter)
        {
            for (int i = 0; i < originalLetters.Length; i++)
            {
                if (originalLetters[i] == letter)
                {
                    return mappedLetters[i];
                }
            }

            return letter;
        }
    }
}