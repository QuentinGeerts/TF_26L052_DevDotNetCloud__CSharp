/*
 * Démonstration 06 - Les boucles
 */


// Permet :
// - De répéter des instructions un certain nombre de fois
// - D'itérer sur les éléments d'une séquence

// 3 éléments importants pour qu'une boucle fonctionne : 
// - Initialisation
// - Condition d'arrêt
// - Incrémentation

// 1.  while

// Syntaxe

/*
    while (condition_booléenne)
    {
        // bloc d'instructions
    }
*/


// Exemple 1: compter de 0 à 9
int i = 0; // 1
while (i < 10) // 2
{
    Console.WriteLine($"i: {i}");
    i++; // 3
}

// Exemple 2: Demander à l'utilisateur d'encoder valeur positive

bool isValid = false;
int result = 0;

while (!isValid)
{
    Console.WriteLine("Entrez une valeur positive :");
    while (!int.TryParse(Console.ReadLine(), out result))
    {
        Console.WriteLine($"Vous devez entrer une valeur numérique, réessayez: ");
    }
    isValid = result >= 0;
}

Console.WriteLine($"Resultat: {result}");



// 2.  do ... while

while (false)
{
    Console.WriteLine("N'exécutera jamais le code.");
}

do
{
    Console.WriteLine("Code exécuté qu'une seule fois");
}
while (false);

// 3.  for

for (int j = 0; j < 10; j++)
{
    // Même code que pour le while
}

for (int j = 0, k = 0, l = 0; j < 10; j++, k += 2, l += 3)
{
    Console.WriteLine($"j= {j} ; k = {k} ; l = {l}");
}

//for (int j = 0; ;j++)
//{
//    Console.WriteLine("Coucou");
//}

// 4.  foreach
// Tout élément est itérable si la classe implémente l'interface :
// - IEnumerable ou IEnumerable<T>

string formation = "Développeur .NET Orienté Cloud Computing";

foreach(char caractere in formation)
{
    Console.Write(caractere.ToString().ToUpper() + " ");
}

int[] entiers = [1, 2, 3, 4, 5, 6];

foreach (int item in entiers)
{
    Console.WriteLine($"Item: {item}");
}