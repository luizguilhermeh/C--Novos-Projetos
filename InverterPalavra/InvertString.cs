using System;

public class InversorDeString
{
    public static void Main()
    {
        Console.Write("Digite uma string para inverter: ");
        string entrada = Console.ReadLine();
        char[] arrayChar = entrada.ToCharArray();
        Array.Reverse(arrayChar);
        string invertida = new string(arrayChar);
        Console.WriteLine($"String invertida: {invertida}");
    }
}
