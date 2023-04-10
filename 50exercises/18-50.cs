//Todo
/*
* Escreva um algoritimo para ler 2 valores e se o segundo valor informado for 0
* deve ser lido um novo valor, e imprimir o resultado do primeiro valor pelo segundo
*/
double divisor = 0;
Console.Write("Insira o dividendo:");
double dividend = double.Parse(Console.ReadLine());
for (double i = 0; divisor == 0;)
{
   Console.Write("Insira o divisor:");
   divisor = double.Parse(Console.ReadLine());
}
Console.WriteLine(dividend / divisor);