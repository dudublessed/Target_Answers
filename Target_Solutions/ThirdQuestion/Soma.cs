using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Target_Solutions.ThirdQuestion
{
    class Soma
    {
        int indice = 12;
        int soma = 0;
        int k = 1;

        public void ProcessSoma()
        {
            while (k < indice)
            {
                k++;
                soma += k;

            }

            Console.WriteLine($"Valor de soma: {soma}\n");
        }

    }
}
