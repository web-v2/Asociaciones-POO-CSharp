using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsociacionesPOO
{
    internal class Cliente
    {
        //Atributos
        private string nombres, apellidos, numId, cell;

        //Contructores
        public Cliente()
        {
            nombres = "";
            apellidos = "";
            numId = "";
            cell = "";
        }
        public Cliente(string nombres, string apellidos, string numId, string cell)
        {
            this.nombres = nombres;
            this.apellidos = apellidos;
            this.numId = numId;
            this.cell = cell;
        }

        //Getters and Setters
        public string Nombres { get => nombres; set => nombres = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string NumId { get => numId; set => numId = value; }
        public string Cell { get => cell; set => cell = value; }
    }
}
