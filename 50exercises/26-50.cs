//Todo
/*
* Ler 10 valores e Escreva quantos desses valores são NEGATIVOS
*/
int i = 1;
int negative = 0;
while (i <= 10)
{
   Console.WriteLine($"Escreva o {i}° valor: ");
   int number = int.Parse(Console.ReadLine());
   number < 0 ? negative++ : negative+0;
   i++;
}
Console.WriteLine($"Tivemos {negative} números negativos");