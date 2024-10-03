using System;

// Declarar variáveis
string nome;
int experiencia;
string continuar = "S";

do
{
    // Solicitar o nome do herói
    Console.Write("Digite o nome do herói: ");
    nome = Console.ReadLine();

    // Solicitar a quantidade de experiência (XP)
    Console.Write("Digite a quantidade de experiência (XP) do herói: ");
    experiencia = int.Parse(Console.ReadLine());

    // Classificação do nível do herói
    string nivel;

    if (experiencia <= 1000)
    {
        nivel = "Ferro";
    }
    else if (experiencia >= 1001 && experiencia <= 2000)
    {
        nivel = "Bronze";
    }
    else if (experiencia >= 2001 && experiencia <= 5000)
    {
        nivel = "Prata";
    }
    else if (experiencia >= 5001 && experiencia <= 7000)
    {
        nivel = "Ouro";
    }
    else if (experiencia >= 7001 && experiencia <= 8000)
    {
        nivel = "Platina";
    }
    else if (experiencia >= 8001 && experiencia <= 9000)
    {
        nivel = "Ascendente";
    }
    else if (experiencia >= 9001 && experiencia <= 10000)
    {
        nivel = "Imortal";
    }
    else
    {
        nivel = "Radiante";
    }

    Console.WriteLine($"O Herói de nome {nome} está no nível de {nivel}.");
    Console.Write("Deseja continuar use S/N: ");
    continuar = Console.ReadLine();
}while(continuar != "N");
Console.WriteLine("Fim !");