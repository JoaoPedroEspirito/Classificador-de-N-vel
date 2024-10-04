using System;
using Criando_seu_Heroi.Models;

Consulta consulta = new Consulta();
// Declarar variáveis
string nome;
int vitoria = 0, derrota = 0 , experiencia = 0;

string continuar = "S";

do
{
    // Solicitar o nome do herói
    Console.Write("Digite o nome do herói: ");
    nome = Console.ReadLine();

    // Solicitar a quantidade de experiência (XP)
    Console.Write("Digite a quantidade de experiência (XP) do herói: ");
    experiencia = int.Parse(Console.ReadLine());

    Console.Write("Digite a quantidade de vitórias do herói: ");
    vitoria = int.Parse(Console.ReadLine());

    Console.Write("Digite a quantidade de derrotas do herói: ");
    derrota = int.Parse(Console.ReadLine());

    // Classificação do nível do herói
    consulta.Classificacao(nome,experiencia);

    Console.WriteLine(consulta.SaldoRank(vitoria,derrota));

    Console.Write("Deseja continuar use S/N: ");
    continuar = Console.ReadLine().ToUpper();
}while(continuar != "N");
Console.WriteLine("Fim !");