using System;

namespace Ordenacao_de_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = { 1, 19, 10, 7, 2, 9, 11, 88, 15, 70 };

            bool LoopMenu = true;

            while (LoopMenu)
            {
                Console.WriteLine("Escolha uma opção");
                Console.WriteLine("Opção 1: Imprimir os números do array");
                Console.WriteLine("Opção 2: Ordenar os números do array");
                Console.WriteLine("Opção 3: Enserrar o programa");
                int opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        for (int i = 0; i < numeros.Length; i++)
                        {
                            Console.WriteLine($"Elemento na pozição: {i+1}: {numeros[i]}");
                        }
                        break;

                        case 2:
                        Console.WriteLine("Ok, fazendo a ordenação");

                        for (int i = 0; i < numeros.Length -1; i++) 
                        {
                            for (int j = 0; j < numeros.Length - 1 - i; j++)
                            {
                                if (numeros[j] > numeros[j + 1])
                                {
                                    int temp = numeros[j];
                                    numeros[j] = numeros[j + 1];
                                    numeros[j + 1] = temp;
                                    break;
                                }
                            }
                        }
                        break;

                        case 3:
                        Console.WriteLine("Obrigaodo por usar o nosso sistema!");
                        break; 
                }
            }
        }
    }
}
