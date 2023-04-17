//Todo
/*
* Escreva um algoritmo para ler 10 números e ao final da leitura escrever a soma total dos 10 números lidos
*/
double total = 0;
for(int i = 1;i<=10;i++){
   Console.Write("Qual o número a ser somado: ");
   total += double.Parse(Console.ReadLine());
}
Console.WriteLine($"O Valor total é {total}");