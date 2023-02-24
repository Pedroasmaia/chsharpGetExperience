// See https://aka.ms/new-console-template for more information
Console.WriteLine("Vamos jogar os dados!");
Console.WriteLine("Quantos lados o seu dado tem?");
int sidesDice = int.Parse(Console.ReadLine()) + 1;
Console.WriteLine("Quantos jogadas você quer fazer?");
int rollsDice = int.Parse(Console.ReadLine());
int sumRolls = 0;
for (int i = 0;i < rollsDice; i++)
{
    Console.WriteLine("======================");
    Console.Write($"Jogada n°{i+1}: ");
    int roll = new Random().Next(1,sidesDice);
    Console.WriteLine(roll);
    sumRolls += roll;
}
Console.WriteLine($"A soma de todas as suas jogadas foram {sumRolls}");
Console.WriteLine($"O resultado médio da suas jogadas foi {sumRolls/rollsDice}");