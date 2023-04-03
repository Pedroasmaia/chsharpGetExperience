//Todo
/*
Escreva um algoritmo que leia idade de uma pessoa expressa em anos meses e dias
Escreva a idade dessa pessoa expressa em dias
Considerar 
ANO = 365 Dias
MES = 30 Dias
*/
Console.WriteLine("Você tem quantos anos?");
int yearsOld = int.Parse(Console.ReadLine());
Console.WriteLine("Desde que você fez aniversario, quantos meses se passaram?");
int monthsOld = int.Parse(Console.ReadLine());
Console.WriteLine("Faltam quantos dias, para completar mais um mÊs desde que foi seu aniversario?");
int daysOld = int.Parse(Console.ReadLine());

int agePerson = (yearsOld * 365) + (monthsOld * 30) + daysOld;
Console.WriteLine($"Sua idade em dias é {agePerson}");
