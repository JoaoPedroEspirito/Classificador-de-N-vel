using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace Criando_seu_Heroi.Models
{
    public class Consulta
    {
        public void Classificacao(string p_nome, int p_xp)
        {
            string nivel;

            if (p_xp <= 1000)
            {
                nivel = "Ferro";
            }
            else if (p_xp >= 1001 && p_xp <= 2000)
            {
                nivel = "Bronze";
            }
            else if (p_xp >= 2001 && p_xp <= 5000)
            {
                nivel = "Prata";
            }
            else if (p_xp >= 5001 && p_xp <= 7000)
            {
                nivel = "Ouro";
            }
            else if (p_xp >= 7001 && p_xp <= 8000)
            {
                nivel = "Platina";
            }
            else if (p_xp >= 8001 && p_xp <= 9000)
            {
                nivel = "Ascendente";
            }
            else if (p_xp >= 9001 && p_xp <= 10000)
            {
                nivel = "Imortal";
            }
            else
            {
                nivel = "Radiante";
            }

            Console.WriteLine($"\tO Herói {p_nome} está no nível de {nivel}.");
        }
        
        public string SaldoRank (int p_vitoria, int p_derrota)
        {
            int saldo = p_vitoria - p_derrota; // Calcula o saldo de vitórias menos derrotas
            string rank;
            string msg;

            switch (p_vitoria)
            {
                case < 10:
                    rank = "Ferro";
                    break;
                case >= 11 and <= 20:
                    rank = "Bronze";
                    break;
                case >= 21 and <= 50:
                    rank = "Prata";
                    break;
                case >= 51 and <= 80:
                    rank = "Ouro";
                    break;
                case >= 81 and <= 90:
                    rank = "Diamante";
                    break;
                case >= 91 and <= 100:
                    rank = "Lendário";
                    break;
                default:
                    rank = p_vitoria >= 101 ? "Imortal" : "Ferro";
                    break;
            }
            msg = $"\tO Herói tem de saldo de {saldo} está no Rank de {rank}";
            return msg;
        }

    }
}