﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FFM
{
    public class Juridica : Pessoa
    {
        private String sCNPJ;

        public string SCNPJ { get => sCNPJ; set => sCNPJ = value; }
    }
}