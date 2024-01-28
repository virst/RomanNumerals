namespace RomanNumerals
{
    public static class RomanNumeralsUtils
    {
        private readonly static (int num, string rom)[] romanNums =
            new[]{
              (1000, "M"),
              (900, "CM"),
              (500, "D"),
              (400, "CD"),
              (100, "C"),
              (90, "XC"),
              (50, "L"),
              (40, "XL"),
              (10, "X"),
              (9, "IX"),
              (5, "V"),
              (4, "IV"),
              (1, "I"),
            };

        public static string ToRoman(int n)
        {
            string s = "";

            foreach (var (num, rom) in romanNums)
            {
                while (n >= num)
                {
                    s += rom;
                    n -= num;
                }
            }

            return s;
        }

        public static int FromRoman(string romanNumeral)
        {
            int num = 0;

            for (int i = 0; i < romanNums.Length;)
            {
                if (romanNumeral.StartsWith(romanNums[i].rom))
                {
                    num += romanNums[i].num;
                    romanNumeral = romanNumeral[romanNums[i].rom.Length..];
                    continue;
                }
                i++;
            }

            return num;
        }
    }
}
