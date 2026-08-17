object o = "Quentin";

if (o is string)
{
    string oString2 = (string)o;
    Console.WriteLine($"o est un chaîne de caractère");
    Console.WriteLine(((string)o).Length);
    Console.WriteLine(oString2.Length);
}

if (o is string oString)
{
    Console.WriteLine(oString.Length);
}




object monObjet = "ma string";

string? str = monObjet as string;

object monObjet2 = 5;

int? monEntier = monObjet2 as int?;
Nullable<int> monEntier2 = monObjet2 as Nullable<int>;

int a = int.MaxValue;
int b = a + 1;


Console.WriteLine();



