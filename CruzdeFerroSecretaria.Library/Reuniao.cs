using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CruzdeFerroSecretaria.Library
{
    public class Reuniao
    {
        private int ReuniaoID;
        private DateTime Data;
        private List<Integrante> Participantes;
        private List<Evento> Eventos;
        private string Avisos;
        private string AtaFinal;
    }
}
