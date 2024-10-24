using System.Text.RegularExpressions;

namespace PW_Check
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Password must contain: 8-20 characters, upper case letters, lower case letters, numbers and min. 1 special character");
                Console.WriteLine("Type password below: ");
                string pass = Console.ReadLine();
                bool has_specialChars = false;

                foreach (char c in pass)
                {
                    if (char.IsLetter(c) || char.IsDigit(c))
                        continue;
                    has_specialChars = true;
                    break;
                }


                if (pass.Length >= 8 && pass.Length < 20 && pass.Any(char.IsUpper) && pass.Any(char.IsLower) && pass.Any(char.IsDigit) && has_specialChars)
                {
                    Console.WriteLine("Password accepted");
                    break;
                }
                else
                    Console.WriteLine("Password does not meet requirements");
            }
        }
    }
}


    