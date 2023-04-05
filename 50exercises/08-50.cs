//Todo
/*
Ler um valor e escreva "O valor é maior que 10" se for, caso contrario "O valor é menor que 10"
*/
Console.Write("Escreva um valor: ");
int value = int.Parse(Console.ReadLine());
if(value < 10){
   Console.WriteLine($"{value} é menor que 10");
}else if(value > 10){
   Console.WriteLine($"{value} é maior que 10");
}
else{
   Console.WriteLine($"Você digitou o número {value}");
}
