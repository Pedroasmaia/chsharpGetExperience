//Todo
/*
* Uma loja esta levantando o valor total de todas as mercadorias em estoque. Escreva um algoritmo que permita a entrada das seguintes informações:
a- O número total de mercadorias no estoque
b- O valor de cada mercadoria
* Imprima o valor total em estoque e a média de valor das mercadorias
*/
Console.WriteLine("Escreva quantos items você quer adicionar: ");
int quantityItems = int.Parse(Console.ReadLine());
decimal valueTotal = 0m;
for (int i = 1; i <= quantityItems; i++)
{
   Console.Write($"Qual o valor do produto n°{i}: ");
   valueTotal += decimal.Parse(Console.ReadLine());
}
Console.WriteLine($"O Valor total foi: R${valueTotal}");
Console.WriteLine($"O Valor médio foi: R${valueTotal/quantityItems}");