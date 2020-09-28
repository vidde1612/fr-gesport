using System;

namespace frågesport
{
    class Program
    {
        static int points = 0;
        static int maxPoints = 3;
        static void Main(string[] args)
        {
            intro();
            fraga1();
            fraga2();
            fraga3();
            endPoints();
        }

        static void intro()
        {
            Console.WriteLine("Hej och välkommen till denna frågesport");
            Console.WriteLine("du kommer få tre frågor och hur många försök du vill på varje fråga");
            Console.WriteLine("För att svara på frågorna skriver du ordet som du tror är rätt, lycka till!");
            Console.ReadLine();

            Console.Clear();
        }
        static void fraga1()
        {
            Console.WriteLine("Vilken linje representerar dessa meningar?");
            Console.WriteLine("vi har håltimme nu igen");
            Console.WriteLine("vi har inga läxor närmaste 5 veckorna!");
            Console.WriteLine("vill du ha plusmeny på det?");
            Console.WriteLine("skriv programmets namn");
            //    svar a / svar b / svar c / rätt svar
            fraga("estet", "el", "teknik", "estet");
            points++;

            Console.Clear();
        }

        static void fraga2()
        {
            Console.WriteLine("Vilken maträtt tror du är min favoriträtt?");

            fraga("carbonara", "tacos", "sushi", "sushi");
            points++;

            Console.Clear();
        }

        static void fraga3()
        {
            Console.WriteLine("Vart kommer lukas ifrån?");

            fraga("kungsbacka", "kungsängen", "kungsfronten", "kungsängen");
            points++;

            Console.Clear();
        }

        static void endPoints()
        {
            Console.WriteLine("grattis, du har klarat denna frågesport.");
            Console.WriteLine("Jag vet inte hur många försök det tog men det är över nu :)");
            Console.ReadLine();
        }
        

        static void fraga(string a, string b, string c, string inAnswer)
        {
            string inputAnswer = "";
            while (inputAnswer != inAnswer)
            {
                Console.WriteLine("a = " + a);
                Console.WriteLine("b = " + b);
                Console.WriteLine("c = " + c);

                inputAnswer = Console.ReadLine();
            }
        }

    }
}

