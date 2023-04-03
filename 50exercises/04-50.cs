//Todo
/*
Escreva um algoritmo para ler um número total de eleitores em um municípo, o número de votos em brancos, nulos e válidos.
Calcule e escreva o percentual que cada um representa em relação ao total de eleitores.
*/
Console.Write("Escreva o total de eleitores: ");
int totalVoters = int.Parse(Console.ReadLine());
Console.Write("Escreva o total de votos brancos: ");
int whiteVotes = int.Parse(Console.ReadLine());
Console.Write("Escreva o total de votos nulos: ");
int nullVotes = int.Parse(Console.ReadLine());
Console.Write("Escreva o total de votos válidos: ");
int validVotes = int.Parse(Console.ReadLine());

double percentageWhite = (whiteVotes * 100)/totalVoters;
double percentageNull = (nullVotes * 100)/totalVoters;
double percentageValid = (validVotes * 100)/totalVoters;

if(percentageNull+percentageValid+percentageWhite != 100){
Console.WriteLine("A porcentagem total não ficou em 100% os dados inseridos devem estar incorretos");
}
else{
Console.WriteLine($"Percentual de votos brancos: {percentageWhite}%");
Console.WriteLine($"Percentual de votos nulos: {percentageNull}%");
Console.WriteLine($"Percentual de votos validos: {percentageValid}%");
}



