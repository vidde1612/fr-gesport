using System;

namespace frågesport
{
    class Program
    {
        static void Main(string[] args)
        {
            int points = 0;
            Console.WriteLine("Vilken linje representerar dessa meningar?");
            Console.WriteLine("vi har håltimme nu igen");
            Console.WriteLine("vi har inga läxor närmaste 5 veckorna!");
            Console.WriteLine("vill du ha plusmeny på det?");
            Console.WriteLine("skriv programmets namn");
            //    svar a / svar b / svar c / rätt svar
            fraga("estet", "el", "teknik", "estet");
            points++;

            Console.Clear();
            console.writeline("");
            console.writeline("");
            console.writeline("");
            console.writeline("");
            console.writeline("");
            fraga("a", "b", "c", "b");
            points++;

            string Program = "";

/*
            while (Program != "estet")
             {
            Console.WriteLine("Vilken linje representerar dessa meningar?");
            Console.WriteLine("vi har håltimme nu igen");
            Console.WriteLine("vi har inga läxor närmaste 5 veckorna!");
            Console.WriteLine("vill du ha plusmeny på det?");

            Console.WriteLine("a = estet");
            Console.WriteLine("b = el");
            Console.WriteLine("c = teknik");

            Program = Console.ReadLine();
             }
*/
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
