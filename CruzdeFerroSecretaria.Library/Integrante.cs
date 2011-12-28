using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CruzdeFerroSecretaria.Library
{
    public class Integrante
    {
        public int IntegranteID { get; set; }
        public string Name { get; set; }
        public EscudoEnum Hierarquia { get; set; }
        //public Endereco oEndereco { get; set; }
        public string Celular { get; set; }
        public string Telefone { get; set; }
        public string Foto { get; set; }        
    }
}
