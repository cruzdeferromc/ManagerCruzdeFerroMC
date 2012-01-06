using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CruzdeFerroSecretaria.Library
{
    public class Reuniao
    {
        public int ReuniaoID { get; set; }
        public DateTime Data { get; set; }
        public List<Integrante> Participantes { get; set; }
        public List<Evento> Eventos { get; set; }
        public List<string> Avisos { get; set; }
        public string AtaFinal { get; set; }
    }
}
