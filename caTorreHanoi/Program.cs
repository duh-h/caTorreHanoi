using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        Hanoi(3, 'A', 'C', 'B');
    }

    static void Hanoi(int n, char origem, char destino, char auxiliar)
    {
        if (n == 1)
        {
            Console.WriteLine($"Mova o disco 1 da torre {origem} para a torre {destino}");
            return;
        }
        Hanoi(n - 1, origem, auxiliar, destino);
        Console.WriteLine($"Mova o disco {n} da torre {origem} para a torre {destino}");
        Hanoi(n - 1, auxiliar, destino, origem);
    }

}
