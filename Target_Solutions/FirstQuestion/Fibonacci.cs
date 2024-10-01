using System;
using System.Collections.Generic;

public class Fibonacci
{
    private List<int> fibonacci;
    private int trialNumber;

    public Fibonacci(int trialNumber)
    {
        // Inicializa a lista com os dois primeiros números da sequência de Fibonacci.
        fibonacci = new List<int> { 0, 1 };
        this.trialNumber = trialNumber;
    }

    public void Calculate()
    {
        int nextSequenceNumber;

        for (int i = 0; i < fibonacci.Count; i++)
        {
            // Verifica se há um próximo número na sequência
            if (i + 1 < fibonacci.Count)
            {
                nextSequenceNumber = fibonacci[i] + fibonacci[i + 1];

                // Adiciona o elemento ao fim da lista.
                fibonacci.Add(nextSequenceNumber);
            }

            // Verifica se a lista contém o elemento (trialNumber).
            if (fibonacci.Contains(trialNumber))
            {
                Console.WriteLine($"O número informado pertence à sequência de Fibonacci. Número: {trialNumber}\n");
                return; 
            }

            // Verifica se o elemento atual da lista é maior que (trialNumber).
            if (fibonacci[i] > trialNumber)
            {
                Console.WriteLine($"O número informado não pertence à sequência de Fibonacci. Número: {trialNumber}\n");
                return; 
            }
        }
    }
}
