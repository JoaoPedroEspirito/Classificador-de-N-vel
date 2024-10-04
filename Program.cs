using System;
using Criando_seu_Heroi.Models;

class Program
{
    static void Main()
    {
        string nome, tipo;
        int idade = 0;
        string continuar = "S";

        do
        {
            // Solicitar o nome do herói
            Console.Write("Digite o nome do Herói: ");
            nome = Console.ReadLine();

            // Solicitar a idade do herói
            Console.Write("Digite a idade do Herói: ");
            idade = int.Parse(Console.ReadLine());

            // Solicitar a classe do herói
            Console.Write("Digite a classe do Herói (mago, guerreiro, monge, ninja): ");
            tipo = Console.ReadLine().ToLower();

            // Criar um objeto da classe 'Classe' com os valores fornecidos
            Classe heroi = new Classe(nome, idade, tipo);

            // Exibir o ataque do herói
            heroi.Ataque();

            // Perguntar se o usuário deseja continuar
            Console.Write("Deseja continuar? (S/N): ");
            continuar = Console.ReadLine().ToUpper();

        } while (continuar != "N");

        Console.WriteLine("Fim!");
    }
}
