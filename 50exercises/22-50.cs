//Todo
/*
* Ler um valor "x" e imprimir todos os valores inteiros entre 1(inclusive) e n. Considere x sempre maior que zero.
*/
Console.WriteLine("Insira um valor maior que 0:");
int value = int.Parse(Console.ReadLine());
while (value <= 0)
{
   Console.WriteLine("Insira um valor maior que 0:");
   value = int.Parse(Console.ReadLine());
}
Console.WriteLine($"Esses são todos os valores até chegar em {value}");
for (int i = 1; i <= value; i++)
{
   Console.WriteLine(i);
}