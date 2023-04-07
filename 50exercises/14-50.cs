//Todo
/*
* Ler 3 valores e informar o maior
*/
Console.Write("Escreva o primeiro número: ");
int oneValue = int.Parse(Console.ReadLine());
Console.Write("Escreva o segundo número: ");
int twoValue = int.Parse(Console.ReadLine());
Console.Write("Escreva o terceiro número: ");
int threeValue = int.Parse(Console.ReadLine());

if(oneValue >= twoValue && oneValue >= threeValue){
   Console.WriteLine($"O maior valor é {oneValue}");
}
else if(twoValue>= oneValue && twoValue >= threeValue){
   Console.WriteLine($"O maior valor é {twoValue}");
}
else{
   Console.WriteLine($"O maior valor é {threeValue}");
}