//Todo
/*
Ler duas notas dos alunos e diga se ele foi aprovado ou não, considere a média 7.0
*/
Console.Write("Escreva o resultado da 1° prova: ");
decimal Grade = decimal.Parse(Console.ReadLine());
Console.Write("Escreva o resultado da 2° prova: ");
Grade += decimal.Parse(Console.ReadLine());

if(Grade/2 >= 7.0m){
   Console.WriteLine("Você foi Aprovado");
   Console.WriteLine($"Sua média foi:{Grade/2}");
}
else{
   Console.WriteLine($"Sua média foi:{Grade/2}");
   Console.WriteLine("Você foi Reprovado");;
}