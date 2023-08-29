namespace TryParseMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {

            bool isDigit = CustomTryParseWithParse("123", out int result);
            //bool isDigit2 = CustomTryParse("123", out int result);
            Console.WriteLine(result);
            Console.WriteLine(isDigit);
        }

        static bool CustomTryParse(string input, out int result)
        {
            bool isNegative = false;
            int startIndex = 0;

            if (input.Length > 0 && input[0] == '-')
            {
                isNegative = true;
                startIndex = 1;
            }

            int parsedValue = 0;

            for (int i = startIndex; i < input.Length; i++)
            {
                char c = input[i];

                if (c >= '0' && c <= '9')
                {
                    int digit = c - '0';
                    parsedValue = parsedValue * 10 + digit;
                }
                else
                {
                    result = 0;
                    return false;
                }
            }

            if (isNegative)
            {
                parsedValue = -parsedValue;
            }

            result = parsedValue;
            return true;
        }
        static bool CustomTryParseWithParse(string input, out int result)
        {
            result = 0;

            try
            {
                result = int.Parse(input);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}