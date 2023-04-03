//Todo
/*
Escreva um algoritmo para ler um valor (digitado pelo usuário) e escrever na tela o  seu antecessor
*/
Console.WriteLine("Escreva um número:");
int value = int.Parse(Console.ReadLine());
Console.WriteLine($"O antecessor de {value} é {value - 1}");