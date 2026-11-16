using System;

namespace BusTransportInfo.Models
{
    public class RutaBus
    {
        public string NombreRuta {get; set;}
        public ParadaBus UbicacionP {get; set;}
        public string PuntiInicial {get; set;}
        public string PuntoFinal {get; set;}
    }
}