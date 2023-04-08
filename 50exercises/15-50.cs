//Todo
/*
*
* Ler 3 valores e informar em ordem crescente
*/
Console.Write("Escreva o primeiro número: ");
int oneValue = int.Parse(Console.ReadLine());
Console.Write("Escreva o segundo número: ");
int twoValue = int.Parse(Console.ReadLine());
Console.Write("Escreva o terceiro número: ");
int threeValue = int.Parse(Console.ReadLine());
int[] values = { oneValue, twoValue, threeValue };
if (values[0] < values[1] && values[0] < values[2])
{
   Console.WriteLine(values[0]);
   if (values[1] < values[2])
   {
      Console.WriteLine(values[1]);
      Console.WriteLine(values[2]);
   }
   else if (values[2] < values[1])
   {
      Console.WriteLine(values[2]);
      Console.WriteLine(values[1]);
   }
}
else if (values[1] < values[0] && values[1] < values[2])
{
   Console.WriteLine(values[1]);
   if (values[0] < values[2])
   {
      Console.WriteLine(values[0]);
      Console.WriteLine(values[2]);
   }
   else if (values[2] < values[0])
   {
      Console.WriteLine(values[2]);
      Console.WriteLine(values[0]);
   }
}
else if (values[2] < values[0] && values[2] < values[1])
{
   Console.WriteLine(values[2]);
   if (values[0] < values[1])
   {
      Console.WriteLine(values[0]);
      Console.WriteLine(values[1]);
   }
   else if (values[1] < values[0])
   {
      Console.WriteLine(values[1]);
      Console.WriteLine(values[0]);
   }
}