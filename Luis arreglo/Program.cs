using System;

class Program
{
    static void Main()
    {

        char[] c = { 'L', 'u', 'i', 's' };
        Console.WriteLine("el arreglo de caracteres es: ");
        foreach (char letra in c)
        {
            Console.WriteLine(letra);
        }
        Console.WriteLine();

        string nombre = new string(c);

        Console.WriteLine("El nombre es: " + nombre);

        char segundaLetra = c[1];
        Console.WriteLine("la segunda letra es: " + segundaLetra);

        c[3] = 'x';
        Console.Write("el arreglo de caracter modificado es: ");
        foreach (char letra in c)
        {
            Console.WriteLine(letra);
        }
        Console.WriteLine();

        Console.ReadLine();
    }
}