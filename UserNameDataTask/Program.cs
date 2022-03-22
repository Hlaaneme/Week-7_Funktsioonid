using System;

namespace UserNameDataTask
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada eesnime;
            //programm küsib kasutajal sisestada numbrit 1-3;
            //kui kasutaja sisestab '1', siis kuvatakse kasutaja eesnime tagurpidi
            //kui kasutaja valib '2', siis kuvatakse kasutaja eesnime esimest tähte
            //kui kasutaja valib '3', siis kuvatakse kasutaja eesnime pikkust

            Console.WriteLine("Sisesta oma eesnime:");
            string userName = Console.ReadLine();
            
            Console.WriteLine("Sisesta number '1', '2' või '3'");
            char userNumber = Convert.ToChar(Console.ReadLine());

            switch (userNumber)
            {
                case '1':
                    reversedName(userName);
                    break;
                case '2':
                    firstLetter(userName);
                    break;
                case '3':
                    firstNameLenght(userName);
                    break;
                default:
                    Console.WriteLine("Kena päeva!");
                    break;
            }

            
        }

        public static void reversedName(string userInput)
        {
            for (int i = userInput.Length - 1; i >= 0; i--)
            {
                Console.Write(userInput[i]);
            }
        }

        public static void firstLetter(string userInput)
        {
            Console.WriteLine($"Sinu eesnime esimene täht on {userInput[0]}.");
        }

        public static void firstNameLenght(string userInput)
        {
            Console.WriteLine($"Sinu nimi on {userInput.Length} sümbolit pikk.");
        }


    }
}
