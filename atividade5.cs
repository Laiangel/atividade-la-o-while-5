using System;

class Program
{
    static void Main(string[] args)
    {
        int numero;

        do
        {
            Console.Write("Digite um número: ");
            if (int.TryParse(Console.ReadLine(), out numero))
            {
                if (numero % 2 == 0)
                {
                    Console.WriteLine("Parabéns! Você digitou um número par.");
                    break;
                }
                else
                {
                    Console.WriteLine("O número é ímpar. Tente novamente.");
                }
            }
            else
            {
                Console.WriteLine("Por favor, insira um número válido.");
            }
        } while (true);
    }
}

