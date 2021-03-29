using System;

namespace JurosSimples
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            double j, c, i, t, m;
    
            Console.WriteLine("||| Juros simples (j) |||");
            Console.WriteLine("");

            Console.Write("Capital [c] (R$).......: ");
            c = Convert.ToDouble (Console.ReadLine());
            
            Console.Write("Taxa de juros [i] (%)..: ");
            i = Convert.ToDouble (Console.ReadLine());

            Console.Write("Tempo [t] (meses)......: ");
            t = Convert.ToDouble (Console.ReadLine());
        
            j = c * (i / 100) * t;

            Console.WriteLine("");
            Console.WriteLine($"Juros (R$).....: {j:N2} ");

            m = c + j;

            Console.WriteLine($"Montante (R$)..: {m:N2}");
        }
    }
}
