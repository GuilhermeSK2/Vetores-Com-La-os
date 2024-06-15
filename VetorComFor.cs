using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VetoresComLoop
{
    internal class VetorComFor
    {
        public static void Main(string[] args)
        {
            string[] marcas = { "Samsung", "Nokia", "Apple", "Nvidia" };
            for (int i = 0; i < 3; i++) //Declara a variável "i" como uma "contadora" que irá percorrer o vetor começando em "0" e delimitada para imprimir os valores que estão em posição inferior a "3".
            {
                Console.WriteLine(marcas[i]);//Imprime a posição em que a variável "i" está dentro do vetor, de acordo com as vezes que o laço for foi executado e com o incremento (i++).
            }
        }
    }
}
