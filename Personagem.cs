using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula12Classes
{
    internal class Personagem
    {
        // VARIAVEÍS QUE PASSA A SE CHAMAR (ATRIBUTOS)
        public string nome;
        public string raca;
        public int poder;

        // FUNÇÕES QUE PASSA A SE CHAMAR (MÉTODOS)

        public void mostra()
        {
            Console.WriteLine($"Seu personagem é {raca} o nome é {nome} e o pode é {poder}");
        }



    }
}
