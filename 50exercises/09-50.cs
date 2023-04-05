//Todo
/*
Ler um valor e escrever se o mesmo é positivo ou negativo
*/
Console.Write("Escreva um valor: ");
decimal value = decimal.Parse(Console.ReadLine());
if(value < 0){
   Console.WriteLine($"{value} é negativo");
}else if(value >= 0){
   Console.WriteLine($"{value} é positivo");
}
