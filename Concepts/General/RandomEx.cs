using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concepts.General
{
    // https://www.c-sharpcorner.com/article/generating-random-number-and-string-in-C-Sharp/
    public class RandomEx : Random
    {
        public void Exec()
        {
            var result = RandomString(45, true);
            Console.WriteLine($"result : {result}");

        }

        //The Random class is used to create random numbers. (Pseudo-random that is of course.).
        private void ScenarioOne()
        {
            Random rnd = new Random();
            int month = rnd.Next(1, 13);  // creates a number between 1 and 12
            int dice = rnd.Next(10, 17);   // creates a number between 10 and 17
            int card = rnd.Next(5);     // creates a number between 0 and 5

            Console.WriteLine($"month : {month}");
            Console.WriteLine($"dice : {dice}");
            Console.WriteLine($"card : {card}");

        }

        private void ScenarioTwo()
        {
            Random random = new Random();
            int randomNumber = random.Next();

            Console.WriteLine($"randomNumber Range 0 - {int.MaxValue} : {randomNumber}");
            Console.WriteLine($"randomNumber Range 0 - {Int64.MaxValue} : {random.NextInt64()}");
            Console.WriteLine($"randomNumber float : {random.NextSingle()}");

            //Inherited the Random class to use the protected method Sample() 
            Console.WriteLine($"randomNumber double : {Sample()}");

        }

        private void ScenarioThree()
        {
            var generator = new RandomGenerator();
            var randomNumber = generator.RandomNumber(5, 100);
            Console.WriteLine($"Random number between 5 and 100 is {randomNumber}");

            var randomString = generator.RandomString(10);
            Console.WriteLine($"Random string of 10 chars is {randomString}");

            var randomPassword = generator.RandomPassword();
            Console.WriteLine($"Random string of 6 chars is {randomPassword}");

            Console.ReadKey();

        }



        // Generates a random string with a given size.
        public string RandomString(int size, bool lowerCase = false)
        {
            // Instantiate random number generator.
            Random random = new Random();
            var builder = new StringBuilder(size);

            // Unicode/ASCII Letters are divided into two blocks
            // (Letters 65–90 / 97–122):
            // The first group containing the uppercase letters and
            // the second group containing the lowercase.

            // char is a single Unicode character
            char offset = lowerCase ? 'a' : 'A';
            const int lettersOffset = 26; // A...Z or a..z: length=26

            for (var i = 0; i < size; i++)
            {
                var @char = (char)random.Next(offset, offset + lettersOffset);
                builder.Append(@char);
            }

            return lowerCase ? builder.ToString().ToLower() : builder.ToString();
        }
    }
    public class RandomGenerator
    {
        // Instantiate random number generator.
        // It is better to keep a single Random instance
        // and keep using Next on the same instance.
        private readonly Random _random = new Random();

        // Generates a random number within a range.
        public int RandomNumber(int min, int max)
        {
            return _random.Next(min, max);
        }

        // Generates a random string with a given size.
        public string RandomString(int size, bool lowerCase = false)
        {
            var builder = new StringBuilder(size);

            // Unicode/ASCII Letters are divided into two blocks
            // (Letters 65–90 / 97–122):
            // The first group containing the uppercase letters and
            // the second group containing the lowercase.

            // char is a single Unicode character
            char offset = lowerCase ? 'a' : 'A';
            const int lettersOffset = 26; // A...Z or a..z: length = 26

            for (var i = 0; i < size; i++)
            {
                var @char = (char)_random.Next(offset, offset + lettersOffset);
                builder.Append(@char);
            }

            return lowerCase ? builder.ToString().ToLower() : builder.ToString();
        }

        // Generates a random password.
        // 4-LowerCase + 4-Digits + 2-UpperCase
        public string RandomPassword()
        {
            var passwordBuilder = new StringBuilder();

            // 4-Letters lower case
            passwordBuilder.Append(RandomString(4, true));

            // 4-Digits between 1000 and 9999
            passwordBuilder.Append(RandomNumber(1000, 9999));

            // 2-Letters upper case
            passwordBuilder.Append(RandomString(2));
            return passwordBuilder.ToString();
        }
    }
}
