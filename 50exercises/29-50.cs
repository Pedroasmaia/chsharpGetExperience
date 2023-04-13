//Todo
/*
* Ler o número de alunos existentes em uma turma e, após isto, ler as notas destes alunos, calcular e escrever a média aritmética dessas notas lidas
*/
Console.Write("Quantos alunos tem nessa sala:");
int quantityStudent = int.Parse(Console.ReadLine());
double grade = 0;
for (int i = 1; i <= quantityStudent; i++)
{
   Console.Write($"Qual foi a nota do aluno {i}°:");
   grade += double.Parse(Console.ReadLine());
}
Console.WriteLine($"A média aritmética da turma foi: {grade/quantityStudent}");