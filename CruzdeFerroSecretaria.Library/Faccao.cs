using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CruzdeFerroSecretaria.Library
{
    public class Faccao
    {
        public int FaccaoID { get; set; }
        public string Email { get; set; }
        public bool PossuiSede { get; set; }
        public Endereco EnderecoSede { get; set; }
        public string FaccaoNome
        {
            get
            {
                return ("Facção " + EnderecoSede.Cidade);
            }
        }
    }
}
