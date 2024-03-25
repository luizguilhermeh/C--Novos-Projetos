using System;

public class ContadorDePalavras
{
    public static void Main()
    {
        Console.Write("Digite uma frase para contar as palavras: ");
        string frase = Console.ReadLine();
        string[] palavras = frase.Split(new char[] { ' ', '.', '?' }, StringSplitOptions.RemoveEmptyEntries);
        Console.WriteLine($"Número de palavras: {palavras.Length}");
    }
}
