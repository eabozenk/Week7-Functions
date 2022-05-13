using System;

namespace UserNameDataTask
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisesta eesnime;
            //programm küsib kasutajal sisesta numbrit 1-3;
            //kui kasutaja sisestab '1', siis kasutaja eesnime kuvatakse tagurpidi;
            //kui kasutaja valib 2, siis kuvatakse kasutaja eesnime esimest tähte;
            //kui kasutaja valib 3, siis kuvatakse kasutaja eesnime pikkust;

            Console.WriteLine("Sisesta oma eesnimi:");
            string userName = Console.ReadLine();
            Console.WriteLine("vali number 1, 2 või 3");
            int userNumber = Convert.ToChar(Console.ReadLine());

            

            switch (userNumber)
            {
                case '1':
                    Tagurpidi(userName);
                    break;
                case '2':
                    EsimeneTäht(userName);
                    break;
                case '3':
                    Pikkus(userName);
                    break;                
                default:
                    Console.WriteLine("Kena päeva!");
                    break;
            }
        }

        public static void Tagurpidi(string userInput)
        {           
            for (int i = userInput.Length - 1; i >= 0; i--)
            {
                Console.Write(userInput[i]);                
            }
        }

        public static void EsimeneTäht(string userInput)
        {
            Console.WriteLine($"Sinu eesnime esimene täht on {userInput[0]}");           
        }

        public static void Pikkus(string userInput)
        {
            Console.WriteLine($"Sinu nimi on {userInput.Length} sümbolit pikk.");
        }

        
            
        
        



        
    }
}
