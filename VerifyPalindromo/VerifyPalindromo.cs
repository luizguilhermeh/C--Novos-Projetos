using System;

public class VerificadorDePalindromo
{
    public static void Main()
    {
        Console.Write("Digite uma palavra para verificar se é um palíndromo: ");
        string palavra = Console.ReadLine();
        string reverso = new string(palavra.Reverse().ToArray());
        bool ehPalindromo = palavra.Equals(reverso, StringComparison.OrdinalIgnoreCase);
        if (ehPalindromo)
            Console.WriteLine($"{palavra} é um palíndromo.");
        else
            Console.WriteLine($"{palavra} não é um palíndromo.");
    }
}
