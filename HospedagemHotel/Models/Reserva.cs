using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospedagemHotel.Models.Reserva
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; } = new List<Pessoa>();
        public Suite Suite { get; set; } = new Suite();
        public int DiasReservados { get; set; }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospede(List<Pessoa> hospedes)
        {
            Hospedes = hospedes;
        }
        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }
        public int ObterQuantidadeHospedes()
        {
            return Hospedes.Count;
        }
        public decimal CalcularValorTotal()
        { 
            return Suite.ValorDiaria * DiasReservados;
        }
    }
}