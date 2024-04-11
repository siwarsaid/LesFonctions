using System.Net.WebSockets;

namespace LesFonctions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("saisissez vous le premier nombre flottant : ");
            double nb1 = double.Parse(Console.ReadLine());

            Console.Write("saisissez vous le premier nombre flottant : ");           
            double nb2 = double.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.Write("Choisissez votre operation: ");
            var  operation = Console.ReadLine();
            Console.WriteLine();

            while (operation != "terminer")
            {
               
                
                    if (operation == "add")
                    {
                        var resAddition = Addition(nb1, nb2);
                        Console.WriteLine($"{nb1} + {nb2} = {resAddition}");
                        Console.WriteLine();
                    }
                    else if (operation == "soust")
                    {
                        var resSous = Soustraction(nb1, nb2);
                        Console.WriteLine($"{nb1} - {nb2} = {resSous}");
                        Console.WriteLine();
                    }
                    else if (operation == "mult")
                    {
                        double resMulti = Multi(nb1, nb2);
                        Console.Write($"{nb1} * {nb2} = {resMulti}");
                        Console.WriteLine();
                    }
                    else if (operation == "divi")
                    {
                        double resDevi = Devi(nb1, nb2);
                        Console.Write($"{nb1} / {nb2} = {resDevi}");
                        Console.WriteLine();
                    }
                 else if (operation =="modulo")
                {
                    int resModulo = Modulo((int)nb1, (int)nb2);
                    Console.Write("le reste de modulo = " + resModulo);

                }

                    Console.WriteLine();
               

                Console.Write("saisissez vous le premier nombre flottant : ");
                nb1 = double.Parse(Console.ReadLine());

                Console.WriteLine();

                Console.Write("saisissez vous le premier nombre flottant : ");
                nb2 = double.Parse(Console.ReadLine());

                Console.WriteLine();

                Console.Write("Choisissez votre operation: ");
                operation = Console.ReadLine();

                while ((operation != "add") && (operation != "soust") && (operation != "divi") && (operation != "mult") && (operation != "modulo"))
                   if(operation == "terminer")
                {
                        break;
                }
                else {
                        Console.WriteLine("oops!! choisissez la bonne operation!!(add,soust,divi, mult ou terminer pour sortir)");
                        Console.Write("Choisissez votre operation: ");
                        operation = Console.ReadLine();
                    }
               
            }
               
        
        }
        public static double Addition(double a, double b)
        {
            return a + b;
        }
        public static double Soustraction(double a, double b)
        {
            return a - b;
        }
        public static double Multi(double a, double b)
        {
            return a * b;
        }
        public static double Devi(double a, double b)
        {
            return a / b;
        }
        public static int Modulo(int a, int b)
        {

            int c = a % b;
            return c;
        }
    }
}
