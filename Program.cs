Console.Write("O que você pensa de mim? ");
string texto = Console.ReadLine()!;

Console.WriteLine("");
Console.WriteLine("- E sabe o que eu penso de você?");
Console.WriteLine($"{texto.Remove(10)}... NÃO, PERA.");
Console.WriteLine("Tô nervoso");