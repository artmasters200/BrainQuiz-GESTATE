using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestate
{
    class Program
    {
        const string GESTATE = "GESTATE";
        static char[] characters = new char[] { 'E', 'S', 'T', 'T', 'A', 'G', 'E' };
        static bool isFound = false;
        static void Main(string[] args)
        {
            if (characters.Length != GESTATE.Length)
            {
                //handle the error here.
                Console.WriteLine("Error");

            }

            Console.WriteLine("Start");

            GetAllCombinations();

            Console.ReadLine();

        }

        static void GetAllCombinations(string letters = "")
        {
           // Console.WriteLine(letters);

            if (isFound)
                return;

            if (letters.Length < GESTATE.Length)
            {
                foreach (var character in characters)
                {
                    //var occurenceInLetters = letters.Where(c => c == character).Count();
                    //var occurenceInCharacters = characters.Where(c => c == character).Count();
                    //same implementation as above comment but is more native programming approach
                    var occurenceInLetters = GetNumberOccurences(letters, character);
                    var occurenceInCharacters = GetNumberOccurences(GESTATE, character);


                    if (occurenceInLetters == occurenceInCharacters)
                    {
                        continue;
                    }

                    GetAllCombinations(letters + character);
                }
            }
            else
            {
                if (letters == GESTATE)
                {
                    Console.WriteLine(letters);
                    Console.WriteLine("Stop");
                    isFound = true;
                }
            }
        }

        static int GetNumberOccurences(string testString, char testChar)
        {
            var result = 0;

            for (int i = 0; i < testString.Length; i++)
            {
                if (testString[i] == testChar)
                {
                    result++;
                }
            }

            return result;
        }
    }
}
