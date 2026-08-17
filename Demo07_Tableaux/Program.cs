/*
 * Démonstration 07 - Tableaux
 */


// 1.  Tableaux à une dimension

// Déclaration
// Variable nomTableau : Tableau de Type[taille]
// type[] nomTableau; <- Boite vide type tableau
// type[] nomTableau = new type[taille];

using System.Runtime.InteropServices;

int[] mesEntiers = new int[10]; // tableau de 10 entiers (initialisées à la valeur par défaut du type (Entier => 0)
string[] mesStrings = new string[10]; // tableau de 10 chaînes (non instanciées) (initialisées à la valeur par défaut du type (string / objet => null)

int[] mesEntiers2 = new int[] { 1, 2, 3, 4, 5 };
int[] mesEntiers3 = { 1, 2, 3, 4, 5 };
int[] mesEntiers4 = [1, 2, 3, 4, 5]; // Expression collection

object[] myArray = [42, "Quentin", true];

// Récupération de la taille d'un tableau
// > Propriété Length :> tableau.Length

Console.WriteLine($"Taille du tableau: {myArray.Length}");

// Accéder à une case du tableau
// Indexation :> [] => tableau[index]

Console.WriteLine($"mesEntiers2[3]: {mesEntiers2[3]}");
//Console.WriteLine($"mesEntiers2[5]: {mesEntiers2[5]}"); // <!>

mesEntiers2[2] = 42;

// Parcourt d'un tableau

for (int i = 0; i < mesEntiers2.Length; i++)
{
    Console.WriteLine($"{i}: {mesEntiers2[i]}");
}

Console.WriteLine();


// 2.  Tableaux à plusieurs dimensions

// 2.1.  Tableaux orthogonaux

int[][] tabOrtho = new int[3][];
tabOrtho[0] = new int[3];
tabOrtho[1] = new int[3] { 1, 2, 3 };
tabOrtho[2] = [1, 2, 3, 4, 5];

int[][] tabOrtho2 = [
    [1, 2, 3, 4],
    [1],
    [4, 5, 6]
];

Console.WriteLine($"Taille du tableau orthogonal: {tabOrtho2.Length}");
Console.WriteLine($"Taille du sous-tableau[0]: {tabOrtho2[0].Length}");
Console.WriteLine($"Taille du sous-tableau[1]: {tabOrtho2[1].Length}");
Console.WriteLine($"Taille du sous-tableau[2]: {tabOrtho2[2].Length}");

// Parcourir le tableau ortho

for (int i = 0; i < tabOrtho2.Length; i++)
{
    for (int j = 0; j < tabOrtho2[i].Length; j++)
    {
        Console.Write($"[{i}, {j}] : {tabOrtho2[i][j]}\t");
    }
    Console.WriteLine();
}

// 2.2.  Tableaux matriciels

int[,] matrice1 = new int[4, 2];

int[,] matrice2 =
{
    {1, 2 }, // 0
    {3, 4 }, // 1
    {5, 6 }, // 2
    {7, 8 }, // 3
 //  0  1
};

Console.WriteLine($"matrice= {matrice2[0, 1]}");
Console.WriteLine($"Taille: {matrice2.Length}"); // 8
Console.WriteLine($"Taille: {matrice2.GetLength(0)}"); // 4
Console.WriteLine($"Taille: {matrice2.GetLength(1)}"); // 2

for (int i = 0; i < matrice2.GetLength(0); i++)
{
    for (int j = 0; j < matrice2.GetLength(1); j++)
    {
        Console.Write($"[{i}, {j}] : {matrice2[i, j]}");
    }
    Console.WriteLine();
}

// 3.  Les collections



// 4.  Les collections génériques



