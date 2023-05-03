using Lutadores;
using System.Security.Cryptography.X509Certificates;

Personagem user, enemy;

user = new Personagem();
enemy = new Personagem();
Random rand = new Random();

string[] weapons = { "Espada", "Lança", "Arco" };
string[] elements = { "Fogo", "Agua", "Grama", "Luz", "Escuridão" };


Console.WriteLine($"Escolha uma arma: 1-Espada 2-Lança 3-Arco");
int option = int.Parse(Console.ReadLine()) - 1;
user.Arma = weapons[option];

Console.WriteLine($"Escolha um elemento: 1-Fogo 2-Agua 3-Grama 4-Luz 5-Escuridão");
option = int.Parse(Console.ReadLine()) - 1;
user.Elemento = elements[option];
option = rand.Next(1, 99);
user.Nivel = option;
Console.WriteLine("=========================");
Console.WriteLine($"Seu personagem foi montado");
Console.WriteLine($"Sua arma: {user.Arma}");
Console.WriteLine($"Seu elemento: {user.Elemento}");
Console.WriteLine($"Seu nivel: {user.Nivel}");
Console.WriteLine("=========================");

option = rand.Next(1,3);
enemy.Arma = weapons[option];
option = rand.Next(1,5);
enemy.Elemento = elements[option];
option = rand.Next(1,99);
enemy.Nivel = option;

Console.WriteLine("=========================");
Console.WriteLine($"Seu adiversário foi montado");
Console.WriteLine($"Sua arma: {enemy.Arma}");
Console.WriteLine($"Seu elemento: {enemy.Elemento}");
Console.WriteLine($"Seu nivel: {enemy.Nivel}");
Console.WriteLine("=========================");
