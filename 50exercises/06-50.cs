//Todo
/*
Uma Revendedora de carros usados paga seus funcionarios vendedores um salario fixo por mes, mais uma comissão fixa por carro vendido e mais 5% sobre o total de vendas efetuadas.
Escreva um algoritmo que leia o n° de carros vendidos, o valor total das vendas, o valor que recebe por cada carro e o salario fixo e calculeo salário do funcionario
*/
Console.Write("Valor do salario fixo:");
int salaryValue = int.Parse(Console.ReadLine());
Console.Write("Quantos carros ele vendeu: ");
int carQuantity = int.Parse(Console.ReadLine());
Console.Write("Qual a porcentagem da comissão por carro: ");
int comissionValue = int.Parse(Console.ReadLine());
Console.Write("Valor total das vendas: ");
int totalValue = int.Parse(Console.ReadLine());

double liquidSalary = salaryValue + (comissionValue * carQuantity) + 0.05 * totalValue;

Console.WriteLine($"O salario dele é {liquidSalary}");

