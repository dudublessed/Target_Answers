using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Target_Solutions.SecondQuestion
{
    class FindLetter
    {
        private string findLettersString;

        public FindLetter(string findLettersString)
        {
            this.findLettersString = findLettersString;
        }

        public void SearchString()
        {
            // O caractere a ser procurado.
            char letterA = 'a';

            // A quantidade de vezes que o caractere aparece na string.
            int letterAmount = 0;

            // Verifica de antemão se a string não contêm o caractere desejado, possibilitando que o código seja encerrado previamente caso verdadeiro.
            if (!findLettersString.Contains(letterA))
            {
                Console.WriteLine($"A string não contêm a letra A.\n");
            }

            for (int i = 0; i < findLettersString.Length; i++)
            {
                // Verifica se o index atual é igual ao caractere desejado.
                // Caso contrário, o loop reinicia.
                if (findLettersString[i] == letterA)
                {
                    // Caso sim, aumenta em um a quantidade de (letterAmount).
                    letterAmount++;
                }
            }

            Console.WriteLine($"A string contêm a letra A! Quantidade de vezes: {letterAmount}.\n");
        }
    }
}
