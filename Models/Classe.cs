using System;

namespace Criando_seu_Heroi.Models
{
    public class Classe
    {
        // Propriedades da classe
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Tipo { get; set; }
        public string Habilidade { get; set; }

        // Construtor correto
        public Classe(string nome, int idade, string tipo)
        {
            Nome = nome;
            Idade = idade;
            Tipo = tipo;
            Habilidade = Poder(); // Define a habilidade com base no tipo
        }

        // Método para determinar o poder com base no tipo do herói
        public string Poder()
        {
            string hab;

            if (Tipo == "mago")
            {
                hab = "Magia";
            }
            else if (Tipo == "guerreiro")
            {
                hab = "Espada";
            }
            else if (Tipo == "monge")
            {
                hab = "Artes Marciais";
            }
            else if (Tipo == "ninja")
            {
                hab = "Shuriken";
            }
            else
            {
                hab = "Ataque não definido no banco de dados";
            }

            return hab;
        }

        // Método para simular o ataque
        public void Ataque()
        {
            string ataque = Poder();
            Console.WriteLine($"O {Tipo} atacou usando {ataque}");
        }
    }
}
