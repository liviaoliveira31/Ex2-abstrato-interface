﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstratoInterface_2
{
    internal abstract class Passageiro : IPassageiro
    {

        public string Nome { get; set; }
        public DateTime Nascimento { get; set; }

        public void Cadastrar()
        {

        }

        public void Consultar()
        {

        }

        public void ListarTudo()
        {

        }
    }
}
