using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public Reserva(){ }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }
        
        
        public List<Pessoa> Hospedes = new List<Pessoa>();
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {

        }

        public void HospedarNaSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            return 0;
        }
        public decimal CalcularValorDiaria()
        {
            return 0;
        } 
        
    }
}