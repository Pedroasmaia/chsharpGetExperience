//Todo
/*
Ler dois valores e escrever o maior
*/
Console.Write("Escreva um valor: ");
decimal firstValue = decimal.Parse(Console.ReadLine());
Console.Write("Escreva outro valor: ");
decimal secondValue = decimal.Parse(Console.ReadLine());

Console.WriteLine(firstValue > secondValue ? $"{firstValue} é o maior que {secondValue}":$"{secondValue} é maior que {firstValue}");