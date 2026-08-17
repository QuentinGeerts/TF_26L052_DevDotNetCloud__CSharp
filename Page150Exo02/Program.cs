/*
 * Calculer le factoriel d’un nombre entré au clavier.
 */
using System.Numerics;

bool isValid = false;
int number = 0;

Console.WriteLine($"Entrez un nombre positif :");
while (!isValid)
{
    while (!int.TryParse(Console.ReadLine(), out number))
    {
        Console.WriteLine("Ce n'est pas un nombre, réessayez :");
    }
    isValid = number >= 0;
    if (!isValid) Console.WriteLine($"Vous devez entrer un nombre strictement positif, réessayez :");
}

if (number == 0)
    Console.WriteLine($"{number}! = 1");
else
{
    BigInteger factorielle = 1;

    for (int i = 2; i <= number; i++)
    {
        factorielle *= i;
    }

    Console.WriteLine($"{number}! = {factorielle}");
}