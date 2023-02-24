// Imprime instruções na tela
Console.WriteLine("Vamos jogar os dados!");
Console.WriteLine("Quantos lados o seu dado tem?");
//Coleta a quantidade de lados que o Dado tera
int sidesDice = int.Parse(Console.ReadLine()) + 1;
//Solicita a inserção do número de jogadas
Console.WriteLine("Quantos jogadas você quer fazer?");
//Coleta o número de jogadas
int rollsDice = int.Parse(Console.ReadLine());
// Inicia a variável que vai apresentar a soma de todos os resultados
int sumRolls = 0;
//Laço de repetição para executar a quantidade de jogadas que o usuário deseja
for (int i = 0;i < rollsDice; i++)
{
    Console.WriteLine("======================");
    Console.Write($"Jogada n°{i+1}: ");
    //Gera o valor com o limite mínimo sendo 1 e máximo informado pelo usuário + 1
    int roll = new Random().Next(1,sidesDice);
    Console.WriteLine(roll);
    //Acrescenta o valor gerado a soma total
    sumRolls += roll;
}
Console.WriteLine($"A soma de todas as suas jogadas foram {sumRolls}");
Console.WriteLine($"O resultado médio da suas jogadas foi {sumRolls/rollsDice}");