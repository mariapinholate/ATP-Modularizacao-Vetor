using System;

class Preenchimento
{
    public static void Preencher(int[] vetor)
    {
        for (int i = 0; i < vetor.Length; i++)
        {
            Console.Write("Digite um valor: ");
            vetor[i] = int.Parse(Console.ReadLine());
        }
    }

    public static int PosicaoMenor(int[] vetor)
    {
        int posMenor = 0;

        for (int i = 1; i < vetor.Length; i++)
        {
            if (vetor[i] < vetor[posMenor])
            {
                posMenor = i;
            }
        }

        return posMenor;
    }
}