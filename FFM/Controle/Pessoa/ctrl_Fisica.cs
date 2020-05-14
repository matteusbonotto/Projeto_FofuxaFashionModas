using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FFM.Controle.Pessoa
{
    public class Fisica : Pessoa
    {
        private String sCPF;

        public string SCPF { get => sCPF; set => sCPF = value; }
    }
}