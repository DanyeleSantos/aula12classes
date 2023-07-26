
using Aula12Classes;

Console.WriteLine("Hello, Word!");

Personagem guerreiro = new Personagem();
guerreiro.nome = "Conrado";
guerreiro.raca = "Humano";
guerreiro.poder = 100;

guerreiro.mostra();

Personagem mago = new Personagem();
mago.raca = "elfo";
mago.poder = 150;
mago.nome = "Harry";

mago.mostra();

Personagem bruxo = mago;
bruxo.nome = "herminione";
bruxo.mostra();


Personagem boneca  = new Personagem();
boneca.raca = "barbie";
boneca.poder = 300;
boneca.nome = "Margot";

boneca.mostra();







