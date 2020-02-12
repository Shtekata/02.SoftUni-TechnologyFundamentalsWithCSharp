using System;

namespace Password_Validator
{
    class Program
    {
        static void Main(string[] args)
        {
            var pass = Console.ReadLine();
            var numberOfCharacters = NumberOfCharacters(pass);
            var onlyLettersAndDigits = OnlyLettersAndDigits(pass);
            var atLeastTwoDigits = AtLeastTwoDigits(pass);
            if (numberOfCharacters && onlyLettersAndDigits && atLeastTwoDigits) Console.WriteLine($"Password is valid");
            if (!numberOfCharacters) Console.WriteLine($"Password must be between 6 and 10 characters");
            if (!onlyLettersAndDigits) Console.WriteLine($"Password must consist only of letters and digits");
            if (!atLeastTwoDigits) Console.WriteLine($"Password must have at least 2 digits");
        }

        private static bool AtLeastTwoDigits(string pass)
        {
            var ok = true;
            var number = 0;
            for (int i = 0; i < pass.Length; i++)
            {
                if (pass[i] > 47 && pass[i] < 58) number++;
            }
            if (number < 2) ok = false;
            return ok;
        }

        private static bool OnlyLettersAndDigits(string pass)
        {
            var ok = true;
            for (int i = 0; i < pass.Length; i++)
            {
                if ((pass[i] > 47 && pass[i] < 58)
                    || (pass[i] > 64 && pass[i] < 91)
                    || (pass[i] > 96 && pass[i] < 123)) ok = true;
                else { ok = false; break; }
            }
            return ok;
        }

        private static bool NumberOfCharacters(string pass)
        {
            var ok = true;
            if (pass.Length < 6 || pass.Length > 10) ok = false;
            return ok;
        }
    }
}
