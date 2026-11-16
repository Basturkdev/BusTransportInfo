using System;
using System.ComponentModel.DataAnnotations;

namespace BusTransportInfo.Models
{
    class UnidadBus
    {
        public RutaBus RutaActual {get; set;}
        public string PlacaBus {get; set;}
        public bool AireAcondicionado {get; set;}
        public int CapacidadBus {get; set;}
    }
}