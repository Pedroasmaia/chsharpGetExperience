//Todo
/*
Escreva um algoritmo para ler o salário mensal atual de um funcionario e o percentual de reajuste. Calcular e Escreber o valor do novo salário.
*/
Console.Write("Qual é o salário do funcionario: ");
int salary = int.Parse(Console.ReadLine());
Console.Write("Qual é o reajuste do salario: ");
double reajust = double.Parse(Console.ReadLine());
Console.WriteLine($"O Salario novo é R${salary * (reajust / 100) + salary}");
