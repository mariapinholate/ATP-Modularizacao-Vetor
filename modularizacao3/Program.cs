using System;

class Program
{
    public static void Main()
    {
     
        int[] numeros = Sorteio.Sortear();
        Sorteio.Ler(numeros);

        
        Console.Write("Digite o tamanho do vetor: ");
        int n = int.Parse(Console.ReadLine());

        int[] vetor = new int[n];

        Preenchimento.Preencher(vetor);

        int pos = Preenchimento.PosicaoMenor(vetor);

        Console.WriteLine("Posição do menor elemento: " + pos);
        Console.WriteLine("Menor valor: " + vetor[pos]);
    }
}