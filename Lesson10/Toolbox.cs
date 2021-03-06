
namespace Toolbox
{
    using System;

    public static class Tools
    {
        public static int get_int()
        {
            string input = String.Empty;
            int variable = 0;

            do
            {
                input = Console.ReadLine();
            } while(!Int32.TryParse(input, out variable));

            return variable;
        }

        public static char get_char()
        {
            string input = String.Empty;
            char variable = '\0';

            do
            {
            input = Console.ReadLine();
            input = input.Trim();
            variable = input[0].ToUpper();
            } while(!variable.isletter());

            return variable;
        }
    }
}