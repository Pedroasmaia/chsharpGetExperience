//Todo
/*
* Ler 10 valores e Escreva quantos desses valores estão no intervalo[10,20] e quantos deles estão fora
*/
double sumTotal = 0;
for(double i = 1;i<=10;i++){
   Console.Write($"Insira o {i}° valor: ");
   double number = double.Parse(Console.ReadLine());
   sumTotal += number;
}
Console.WriteLine($"A média é {sumTotal/10}");

