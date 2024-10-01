using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Target_Solutions.SecondQuestion;
using Target_Solutions.ThirdQuestion;

namespace Target_Solutions
{
    class Program
    {
        static void Main(string[] args)
        {
            // Questão 1 - Fibonacci
            //
            // Variável do número a ser procurado na sequência de Fibonacci.
            int trialNumber = 4;

            // Cria uma instância do FibonacciCalculator e calcula a sequência.
            Fibonacci fibonacci = new Fibonacci(trialNumber);
            fibonacci.Calculate();

            //

            string findLettersString = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.";

            FindLetter findLetter = new FindLetter(findLettersString.ToLower());
            findLetter.SearchString();

            Soma soma = new Soma();

            soma.ProcessSoma();
        }
    }
}
