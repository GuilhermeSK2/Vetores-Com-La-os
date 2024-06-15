using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VetoresComLoop
{
    internal class VetorComForeach
    {
        public static void Main(string[] args)
        {
            string[] marcas = { "Samsung", "Nokia", "Apple", "Nvidia" };
            foreach (string i in marcas) //Declara a variável "i" como uma "contadora" que irá percorrer o vetor.
            {
                Console.WriteLine(i);//Imprime tudo que a variável leu dentro do vetor.
            }
        }
    }
}
