using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Globalization;

namespace DesafioProjetoHospedagem.Models
{
    public class Suite
    {
        public Suite(){ }
        public Suite(string tipoSuite, int capacidade, decimal valorDiaria, int identificacao, int diasReservados )
        {
            TipoSuite = tipoSuite;
            Capacidade = capacidade;
            ValorDiaria = valorDiaria;
            Identificacao = identificacao;
            DiasReservados = diasReservados;            
        }
        public override string ToString()
        {
            return $"Suite: {this.Identificacao} - Tipo: {this.TipoSuite} - Valor da diária: {this.ValorDiaria.ToString("C")} ";
        }
        public string TipoSuite { get; set; }
        public int Capacidade { get; set; }
        public decimal ValorDiaria { get; set; }
        public int Identificacao {get; set;}
        public int DiasReservados{get; set;}
    }
}