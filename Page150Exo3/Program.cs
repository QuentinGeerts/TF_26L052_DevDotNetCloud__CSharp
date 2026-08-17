/*
 * Grâce à une boucle « for », calculez les x premiers nombre premier
 */

int number = 0;
bool isValid = false;

Console.WriteLine($"Entrez le nombre de nombre premier à afficher :");
while (!isValid)
{
    while (!int.TryParse(Console.ReadLine(), out number))
    {
        Console.WriteLine($"Vous devez entrer un nombre, réessayez :");
    }

    isValid = number >= 0;
}

for (int value = 2, count = 0; count < number; value++)
{

    // Vérifier si le nombre est un nombre premier

    bool isPrime = true;

    for (int i = 2; i <= Math.Sqrt(value); i++)
    {
        if (value % i == 0)
        {
            isPrime = false;
            break;
        }
    }

    if (isPrime)
    {
        Console.WriteLine($"{++count}. {value} est un nombre premier");
    }

}

