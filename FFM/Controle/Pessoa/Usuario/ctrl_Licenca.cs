using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FFM.Controle.Pessoa.Usuario
{
    public class Licenca : Departamento
    {
        private Int32 iID_Licenca;

        public int IID_Licenca { get => iID_Licenca; set => iID_Licenca = value; }
    }
}