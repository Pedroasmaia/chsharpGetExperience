//Todo
/*
* Declare Saldo,Débito e Credito
* Calcule o Salto Atual
* Se o Saldo for >= 0 Mostrar "Saldo Positivo", caso não "Saldo Negativo"
*/

Console.Write("Informe seu saldo: ");
decimal balance = decimal.Parse(Console.ReadLine());
Console.Write("Informe o Debito: ");
decimal debt = decimal.Parse(Console.ReadLine());
Console.Write("Informe o Credito: ");
decimal credit = decimal.Parse(Console.ReadLine());

decimal newBalance = balance + credit - debt;

if(newBalance >= 0){
   Console.WriteLine($"Saldo Positivo de R${newBalance}");
}else{
   Console.WriteLine($"Saldo Negativo de R${newBalance}");
}
