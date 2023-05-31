using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vetor
{
    internal class Program
    {
        public static void Exemplo1()
        {
            //declaração
            int[] vet = new int[6];
            vet[0] = 7;
            vet[5] = 26;
        }
        public static void Exemplo2()
        {
            //usuário digita o valor do vetor e sua posição

            int[] vet2;
            Console.WriteLine("Entre com o tamanho: ");
            int t = int.Parse(Console.ReadLine());
            vet2 = new int[t];
            for (int i = 0; i < t; i++)
            {
                Console.WriteLine("Digite o valor da posição [{0}]: ", i);
                vet2[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < t; i++)
            {
                Console.WriteLine("Põsição[{0}] = {1}", i, vet2[i]);
            }
            Console.ReadLine();
        }
        public static void Exercício1()
        {
            //números aleatórios

            int[] vet2;
            float soma = 0, div;
            Console.WriteLine("Entre com o tamanho: ");
            int t = int.Parse(Console.ReadLine());

            vet2 = new int[t];
            Random rand = new Random();

            for (int i = 0; i < t; i++)
            {
                vet2[i] = rand.Next(10, 50);// rand.Next() cria números aleatório
                soma += vet2[i];
            }
            for (int i = 0; i < t; i++)
            {
                Console.WriteLine("Põsição[{0}] = {1}", i, vet2[i]);
            }
            div = soma / t;
            Console.WriteLine("A média é: " + div);
            
        }
        public static void Exercício2()
        {
            //soma dos números pares e ímpares

            int[] vet2;
            float somaPar = 0, somaImpar = 0;
            Console.WriteLine("Entre com o tamanho: ");
            int t = int.Parse(Console.ReadLine());

            vet2 = new int[t];
            Random rand = new Random();

            for (int i = 0; i < t; i++)
            {
                vet2[i] = rand.Next(10, 50);// rand.Next() cria números aleatório
                if (vet2[i] % 2 == 0)
                    somaPar += vet2[i];
                else
                    somaImpar += vet2[i];
            }
            for (int i = 0; i < t; i++)
            {
                Console.WriteLine("Põsição[{0}] = {1}", i, vet2[i]);
            }

            Console.WriteLine("A soma dos números pares é: " + somaPar);
            Console.WriteLine("A soma dos números ímpares é: " + somaImpar);
        }
        public static void Exercício4()
        {
            //média vetor divisível por 3 e 5

            int[] vet2;
            float soma = 0, div, cont = 0;
            Console.WriteLine("Entre com o tamanho: ");
            int t = int.Parse(Console.ReadLine());

            vet2 = new int[t];
            Random rand = new Random();

            for (int i = 0; i < t; i++)
            {
                vet2[i] = rand.Next(10, 50);// rand.Next() cria números aleatório
                if (vet2[i] % 3 == 0 && vet2[i] % 5 == 0)
                    soma += vet2[i];
                cont++;
            }
            for (int i = 0; i < t; i++)
            {
                Console.WriteLine("Põsição[{0}] = {1}", i, vet2[i]);
            }
            div = soma / t;
            Console.WriteLine("A média é: " + div);
        }
        static void Main(string[] args)
        {
            int op;

            Console.WriteLine("=====MENU=====");
            Console.WriteLine("0 - Exemplo 1: Declaração da variável");
            Console.WriteLine("1 - Exemplo 2: Usuário digita o valor do vetor e sua posição");
            Console.WriteLine("2 - Exercício 1: Números aleatórios");
            Console.WriteLine("3 - Exercício 2: Soma dos números pares e ímpares");
            Console.WriteLine("4 - Exercício 3: Números ordem crescente e decrescente");
            Console.WriteLine("5 - Exercício 4: Média vetor divisível por 3 e 5");
            op = int.Parse(Console.ReadLine());

            switch (op)
            {
                case 0:
                    Exemplo1();
                    break;
                case 1:
                    Exemplo2();
                    break;
                case 2:
                    Exercício1();
                    break;
                case 3:
                    Exercício2();
                    break;
                case 4:
                    //números aleatórios

                    int[] vet2;
                    float soma = 0, div;
                    Console.WriteLine("Entre com o tamanho: ");
                    int t = int.Parse(Console.ReadLine());

                    vet2 = new int[t];
                    Random rand = new Random();

                    for (int i = 0; i < t; i++)
                    {
                        vet2[i] = rand.Next(10, 50);// rand.Next() cria números aleatório
                        soma += vet2[i];
                    }
                    for (int i = 0; i < t; i++)
                    {
                        Console.WriteLine("Põsição[{0}] = {1}", i, vet2[i]);
                        Array.Sort(vet2);
                        Console.WriteLine(vet2);
                        Array.Reverse(vet2);
                        Console.WriteLine(vet2);
                    }
                    div = soma / t;
                    Console.WriteLine("A média é: " + div);
                    break;
                case 5:
                    Exercício4();
                    break;
                default:
                    Console.WriteLine("Valor inválido!");
                    break;
            }
            Console.ReadLine();
        }
    }
}

