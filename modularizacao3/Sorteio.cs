using System;

class Sorteio
{
    public static int[] Sortear()
    {
        int[] vetor = new int[5];
        Random r = new Random();

        for (int i = 0; i < vetor.Length; i++)
        {
            vetor[i] = r.Next(10, 31);
        }

        return vetor;
    }

    public static void Ler(int[] vetor)
    {
        int numero = 0;
        bool acertou = false;

        while (!acertou)
        {
            Console.Write("Digite um número: ");
            numero = int.Parse(Console.ReadLine());

            for (int i = 0; i < vetor.Length; i++)
            {
                if (numero == vetor[i])
                {
                    Console.WriteLine("Você acertou o número!");
                    acertou = true;
                }
            }

            if (!acertou)
            {
                Console.WriteLine("Número incorreto kkkkkkkk");
            }
        }
    }
}