using System;

namespace esercizioCaffè
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            double costo = 0;
            do
            {
                Console.WriteLine("caffè: 1 Ristretto, 2 Normale, 3 Lungo");
                Console.WriteLine("Selezionare prodotto");
                string str = Console.ReadLine();

                switch (str)
                {
                    case "1":
                    case "Ristretto":
                        costo += 0.25;
                        break;
                    case "2":
                    case "Normale":
                        costo += 0.25;
                        goto case "1";
                    case "3":
                    case "Lungo":
                        costo += 0.50;
                        goto case "1";
                    default:
                        Console.WriteLine("Prodotto non valido...inserire 1 2 o 3");
                        break;

                }

                Console.WriteLine($"Premere 1 per terminare gli acquisti...premere un'altro tasto per continuare acquisti.");
                a = int.Parse(Console.ReadLine());
            } while (a != 1);
            if (costo != 1)
            {
                Console.WriteLine($"Per ricevere inserire {costo}");
            }
        }
    }
}
        
    

