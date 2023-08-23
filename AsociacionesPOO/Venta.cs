using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsociacionesPOO
{
    internal class Venta
    {
        //Atributos
        private int numVenta;
        private double totalVenta;

        //Asociaciones
        private Cliente cliente;
        private Fecha fechaVenta;

        //Constructores
        public Venta()
        {
            this.numVenta = 0;
            this.totalVenta = 0;
        }
        public Venta(int numVenta, double totalVenta, Cliente c, Fecha f)
        {
            this.numVenta = numVenta;
            this.totalVenta = totalVenta;
            this.cliente = c;
            this.fechaVenta = f;
        }

        //Getters and Setters
        public int NumVenta { get => numVenta; set => numVenta = value; }
        public double TotalVenta { get => totalVenta; set => totalVenta = value; }
        internal Cliente Cliente { get => cliente; set => cliente = value; }
        internal Fecha FechaVenta { get => fechaVenta; set => fechaVenta = value; }
    }
}
