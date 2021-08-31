using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADS4_24_08_2021_A
{
    class Pessoa
    {
        public string Nome;
        private double CPF;
        public int RA { get; set; }

       /*
        public string UF
        {
            get { .....};
            set { if (UF != "SP")
                { ... }
            };

        }
       */

        public Pessoa()
        {
            Nome = "NADA";
            CPF = 4;
            RA = 3;
        }

        public Pessoa(string Nome)
        {
            this.Nome = Nome;
            CPF = 1;
            RA = 2;
        }

        public Pessoa(string Nome, double CPF)
        {
            this.Nome = Nome;
            CPF = 1;
            RA = 2;
        }
        public Pessoa(double CPF, string Nome)
        {
            this.Nome = Nome;
            CPF = 1;
            RA = 2;
        }

        public double LerCPF()
        {
            return CPF;
        }
        public void EscreverCPF(double xCPF)
        {
            if (xCPF > 10)
            {
                CPF = xCPF;
            }
            else
            {
                CPF = 0;
            }
        }

        public double GetCPF()
        {
            return CPF;
        }
        public void SetCPF(double CPF)
        {
            this.CPF = CPF;
        }





    }
}
