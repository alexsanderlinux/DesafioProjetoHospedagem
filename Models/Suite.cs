using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioProjetoHospedagem.Models
{
    public class Suite
    {
        public Suite(){ }

        public Suite(string tipoSuite, int capacidade, decimal valorDiaria, bool disponibilidade)
        {
            TipoSuite = tipoSuite;
            Capacidade = capacidade;
            ValorDiaria = valorDiaria;
            Disponibilidade = disponibilidade;
        }
        public string TipoSuite { get; set; }
        public int Capacidade { get; set; }
        public decimal ValorDiaria { get; set; }
        public bool Disponibilidade {get; set;}
    }
}