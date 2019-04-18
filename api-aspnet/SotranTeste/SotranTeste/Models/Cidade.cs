using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SotranTeste.Models
{
    public class Cidade
    {
        public string logradouro { get; set; }

        public Cidade() { }

        public Cidade(string l)
        {
            this.logradouro = l;
        }
    }
}