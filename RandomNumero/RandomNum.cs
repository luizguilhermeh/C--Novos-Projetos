using System;

public class GeradorDeNumerosAleatorios
{
    public static void Main()
    {
        Random random = new Random();
        Console.WriteLine("Gerando 6 números aleatórios entre 1 e 60:");
        for (int i = 0; i < 6; i++)
        {
            Console.WriteLine(random.Next(1, 61));
        }
    }
}
