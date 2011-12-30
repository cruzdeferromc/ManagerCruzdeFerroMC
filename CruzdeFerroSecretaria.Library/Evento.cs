using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CruzdeFerroSecretaria.Library
{
    public class Evento
    {
        public int EventoID
        {
            get;
            set;
        }


        public string MotoClube
        {
            get;
            set;
        }


        public DateTime DataInicio
        {
            get;
            set;
        }


        public DateTime DataFim
        {
            get;
            set;
        }

        public Endereco oEndereco
        {
            get;
            set;
        }

        public string Entrada
        {
            get;
            set;
        }
    }
}
