using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsociacionesPOO
{
    internal class Fecha
    {
        //Atributos
        private int dia, mes, anio;


        //Constructores
        public Fecha(int d, int m, int a)
        {
            dia = d;
            mes = m;
            anio = a;
        }
        public Fecha() { 
            dia = 0;
            mes = 0;
            anio = 0;
        }

        //Getters and Setters
        public int Dia { get => dia; set => dia = value; }
        public int Mes { get => mes; set => mes = value; }
        public int Anio { get => anio; set => anio = value; }

        public string darFecha()
        {
            string fec = dia + "/" +mes + "/" + anio;
            return fec;
        }
    }
}
