//Todo
/*
* Uma loja esta levantando o valor total de todas as mercadorias em estoque. Escreva um algoritmo que permita a entrada das seguintes informações:
a- O valor de cada mercadoria
Depois disso perguntar se deseja incluir mais uma mercadoria
*Imprima o valor total em estoque e a média de valor das mercadorias
*/
int quantityItems = 1;
decimal valueTotal = 0m;
int repeat = 1;
while (repeat == 1)
{
   Console.WriteLine("Escreva o valor do items você quer adicionar: ");
   valueTotal += decimal.Parse(Console.ReadLine());
   Console.WriteLine("Deseja adicionar outro item? 1- Sim 2-Não");
   repeat = int.Parse(Console.ReadLine());
   if (repeat == 1)
   {
      quantityItems++;
   }
}


Console.WriteLine($"O Valor total foi: R${valueTotal}");
Console.WriteLine($"O Valor médio foi: R${valueTotal / quantityItems}");