string[] firstNames = { "Pedro", "Dyego", "Marcos", "Augusto","Gerson" ,"Antonio","Leo","Aldo","Eduardo"};
string[] secondNames = { "Souza", "Oliveira", "Araujo", "Bernardo", "Lima","Alvarenga","Oliveira" };
string[] lastNames = { "Maia", "Rodrigues", "Fernandes", "Silva", "Fulchs","Soares","Luna" };

Console.WriteLine("Gerando nomes completos");


Random nameRandom = new Random();
int firstName = nameRandom.Next(firstNames.Length);
int secondName = nameRandom.Next(secondNames.Length);
int lastName = nameRandom.Next(lastNames.Length);

string Persona1 = $"{firstNames[firstName]} {secondNames[secondName]} {lastNames[lastName]}";

Console.WriteLine("============================");
Console.WriteLine($"1° Nome: {Persona1}");
Console.WriteLine("============================");



int firstNameB = nameRandom.Next(firstNames.Length);
int secondNameB = nameRandom.Next(secondNames.Length);
int lastNameB = nameRandom.Next(lastNames.Length);

string Persona2 = $"{firstNames[firstNameB]} {secondNames[secondNameB]} {lastNames[lastNameB]}";

if (Persona1 == Persona2)
{
    Console.WriteLine("Esse 1° nome já foi escolhido,vamos escolher outro");
    firstNameB = nameRandom.Next(firstNames.Length);
    Persona2 = $"{firstNames[firstNameB]} {secondNames[secondNameB]} {lastNames[lastNameB]}";
}

Console.WriteLine($"2° Nome: {Persona2}");
Console.WriteLine("============================");



int firstNameC = nameRandom.Next(firstNames.Length);
int secondNameC = nameRandom.Next(secondNames.Length);
int lastNameC = nameRandom.Next(lastNames.Length);

string Persona3 = $"{firstNames[firstNameC]} {secondNames[secondNameC]} {lastNames[lastNameC]}";

if(Persona1 == Persona3 || Persona2 == Persona3)
{
    Console.WriteLine("Esse 2° nome já foi escolhido,vamos escolher outro");
    firstNameB = nameRandom.Next(firstNames.Length);
    Persona2 = $"{firstNames[firstNameC]} {secondNames[secondNameC]} {lastNames[lastNameC]}";

}
Console.WriteLine($"3° Nome:{Persona3}");
Console.WriteLine("============================");