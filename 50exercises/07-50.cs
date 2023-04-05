//Todo
/*
Faça um algoritmo que leia 3 notas dos alunos;
Considere que é média ponderada, e o peso das notas são
2,3 e 5
*/
Console.Write("Qual foi a 1° nota: ");
double firstGrade = double.Parse(Console.ReadLine()) * 2;
Console.Write("Qual foi a 2° nota: ");
double secondGrade = double.Parse(Console.ReadLine()) * 3;
Console.Write("Qual foi a 3° nota: ");
double thirdGrade = double.Parse(Console.ReadLine()) * 5;

Console.WriteLine($"A Média do aluno é {(firstGrade + secondGrade + thirdGrade)/10}");