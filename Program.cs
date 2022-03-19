string frase;

Console.Write("Digite uma frase: ");
frase = Console.ReadLine()!;

frase = frase   
    .Replace("a", "4")
    .Replace("A", "4")
    .Replace("i", "1")
    .Replace("I", "1")
    .Replace("s", "5")
    .Replace("S", "5")
    .Replace("t", "7")
    .Replace("T", "7")
    .Replace("e", "3")
    .Replace("E", "3")
    .Replace("o", "0")
    .Replace("O", "0");

Console.WriteLine($"{frase}");