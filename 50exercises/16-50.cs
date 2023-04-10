//Todo
/*
* Ler 3 valores representando os lados de um triangulo.
* Calcule e screva se os valores formam ou não um triangulo.
* O valor de cada lado deve ser menor que o a soma dos outros dois lados.
*/
Console.Write("Escreva  a metragem do lado A: ");
int sideA = int.Parse(Console.ReadLine());
Console.Write("Escreva a metragem do lado B: ");
int sideB = int.Parse(Console.ReadLine());
Console.Write("Escreva  a metragem do lado C: ");
int sideC = int.Parse(Console.ReadLine());

if(sideA < sideB + sideC && sideB < sideA + sideC && sideC < sideA + sideB){
   Console.WriteLine("Forma o triangulo");
}
else{
   Console.WriteLine("Não forma o triangulo");
}