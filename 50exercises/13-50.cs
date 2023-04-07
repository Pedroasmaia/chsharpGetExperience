//Todo
/*
Faça um programa para ler a quantidade máxima, minima e atual de um estoque.
Calcule a quantidade média.
Se a quantidade for > ou igual a quantidade média escrever "Não efetuar a compra" se estiver a baixo escrever "Efetuar Compra"
*/
Console.Write("Quantidade máxima no estoque: ");
int quantityMax = int.Parse(Console.ReadLine());
Console.Write("Quantidade minima no estoque: ");
int quantityMin = int.Parse(Console.ReadLine());
Console.Write("Quantidade atual no estoque: ");
int quantityNow = int.Parse(Console.ReadLine());

Console.WriteLine(quantityNow > (quantityMax + quantityMin)/2 ? "Não efetuar a compra":"Efetuar a compra");