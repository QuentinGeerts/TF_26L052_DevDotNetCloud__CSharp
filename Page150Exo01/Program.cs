/*
 * Calculer les 25 premiers nombres de la suite de Fibonacci
 */

int count = 25;
long a = 0, b = 1;

for (int i = 0; i < count; i++)
{
    Console.WriteLine($"{i, 3} : {a}");
    //long temp = a + b;
    //a = b;
    //b = temp;

    (a, b) = (b, a + b);
}