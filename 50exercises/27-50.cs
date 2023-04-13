//Todo
/*
* Ler 10 valores e Escreva quantos desses valores estão no intervalo[10,20] e quantos deles estão fora
*/
int inInterval = 0;
int outInterval = 0;
for(int i = 1;i<=10;i++){
   Console.Write($"Insira o {i}° valor: ");
   int number = int.Parse(Console.ReadLine());
   if(number <=20 && number >=10){
      inInterval++;
   }
   else{
      outInterval++;
   }
}
Console.WriteLine($"Foram {inInterval} dentro do intevalo");
Console.WriteLine($"Foram {outInterval} fora do intevalo");
