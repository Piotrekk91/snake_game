using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadania_rekrutacyjne
{
    internal static class Interview
    {
        public static void OpenOrCloseDoor()
        {

            List<bool> doors = new List<bool>();

            for (int i = 1; i <= 100; i++)
            {
                doors.Add(false);
            }
            for (int j = 0; j <= 100; j++)
            {
                j = j + 1;

                for (int k = 0; k < 100; k += j)
                {
                    doors[k] = !doors[k];

                }

            }
            for (int l = 0; l < 100; l++)
            {
                if (doors[l] == true)
                {
                    Console.WriteLine($"Drzwi numer: {l} są otwarte");

                }
            }

        }
        public static void PrimeNumberCheck(int x)
        {

            var limit = x - 1;

            if (x < 2)
            {
                Console.WriteLine("To nie jest liczba pierwsza");
                return;
            }
            else if( x == 2)
            {
                Console.WriteLine("To jest liczba pierwsza");
                return;
            }
            else if(x % 2 == 0)
            {
                Console.WriteLine("To nie jest liczba pierwsza");
                return;
            }

            for( int i = 3; i <= limit; i += 2)
            {
                if(x % i == 0)
                {
                    Console.WriteLine("To nie jest liczba pierwsza");
                    return;
                }
                          
            }
            Console.WriteLine("To jest liczba pierwsza");

        }
        public static void SumWithOutUsePlus(int a, int b)
        {
            var wynik = a - (-b);
            Console.WriteLine(wynik);

        }
        public static void SumLettersInText(string userInput)
        {
            var text = userInput.Replace(" ", "").ToLower();
            var textLength = text.Length;
            var lettersDict = new Dictionary<string, int>();
            var letterCount = 1;

            for(int i = 0; i < textLength; i++)
            {
                var letter = text[i].ToString();
                if (lettersDict.ContainsKey(letter))
                {                                        
                    ++lettersDict[letter];
                }
                else
                {                                        
                    lettersDict.Add(letter, letterCount);
                }
            }
            foreach(var letterNumber in lettersDict)
            {
                Console.WriteLine(letterNumber);
            }
        }
        
        
        public static int SumOfDifferences(int[] arr)
        {
            Array.Sort(arr);
            var sortedDesc = arr.Reverse().ToArray();
            var sum = 0;
            for (int i = 0; i < sortedDesc.Length - 1; i++)
            {
                sum += sortedDesc[i] - sortedDesc[i + 1];
            }
            return sum;
        }
        public static int MinSum(int[] arr)
        {
            Array.Sort(arr);
            var sum = 0;
            for (int i = 0; i < arr.Length / 2; i++)
            {
                sum += arr[i] * arr[arr.Length - i -1];

            }
            return sum;
        }
        public static string HowMuchILoveYou(int nb_petals)
        {
            string[] howMuch = { "I love you", "a little", "a lot", "passionately", "madly", "not at all" };
            var petalNumber = nb_petals % 6;
            if(petalNumber == 0)
            {
                return howMuch[5];
            }

            return howMuch[petalNumber-1];
        }
        public static bool Consecutive(int[] arr, int a, int b)
        {
            if (arr[0] == a && arr[1] == b)
            {
                return true;

            }
            if (arr[arr.Length - 1] == a && arr[arr.Length - 2] == b)
            {
                return true;
            }
            for (int i = 1; i < arr.Length; i++)
            {
                    if (arr[i] == a && arr[i - 1] == b || arr[i] == a && arr[i + 1] == b)
                    {
                        return true;
                    }
                  
            }
            return false;
        }
        public static int Divisors(int n)
        {
            var dividentNumber = 0;
            for( int i = 1; i <= n; i++)
            {
                if (n% i == 0)
                {
                    ++dividentNumber;
                }
                
            }
            return dividentNumber;
        }
        public static string ToCamelCase(string str)
        {
            
            var separateStr = str.Split('_', '-');
            for(int i = 1; i < separateStr.Length; i++)
            {
               separateStr[i][0].ToString().ToUpper();
            }
            var joinStr = string.Join(' ', separateStr);

            return joinStr;
        }

        public static int GetVowelCount(string str)
        {
            int vowelCount = 0;
            var strRemoveSpaces = str.Replace(" ", "");

            for(int i =0; i < strRemoveSpaces.Length; i++)
            {
                if (strRemoveSpaces[i].ToString() =="a" || strRemoveSpaces[i].ToString() == "e"
                    || strRemoveSpaces[i].ToString() == "i" || strRemoveSpaces[i].ToString() == "o" || strRemoveSpaces[i].ToString() == "u")
                {
                    vowelCount++;
                }
            }


            return vowelCount;
        }


        public static string HighAndLow(string numbers)
        {

            return "throw towel";
        }




    }
}
