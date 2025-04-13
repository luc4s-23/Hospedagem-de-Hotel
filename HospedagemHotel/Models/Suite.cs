using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospedagemHotel.Models
{
    public class Suite
    {
        public string TipoSuite { get; set; } = string.Empty;
        public int Capaciadade { get; set; }
        public decimal ValorDiaria { get; set; }

        public Suite(string tipoSuite, int capacidade, decimal valorDiaria){
            TipoSuite = tipoSuite;
            Capaciadade = capacidade;
            ValorDiaria = valorDiaria;
        }
       public Suite(){
        
       }
    }
}