namespace RomanNumbersConverter
{
    public class RomanNumbersConverter
    {
        private static Dictionary<string, int> romanNumbersTable = new Dictionary<string, int>()
        {
            {"I", 1},
            {"V", 5},
            {"X", 10},
            {"L", 50},
            {"C", 100},
            {"D", 500},
            {"M", 1000}
        };
        
        public int Convert(string romanNumber)
        {
            int accumulator = 0;
            int lastRightNeighbor = 0;
            for (int i = romanNumber.Length - 1; i >= 0; i--)
            {
                int current = romanNumbersTable[romanNumber[i].ToString()];
                int multiplier = 1;

                if (current < lastRightNeighbor)
                    multiplier = -1;

                accumulator += current * multiplier;
                lastRightNeighbor = current;
            }

            return accumulator;
        }
    }
}
