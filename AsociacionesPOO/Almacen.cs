using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsociacionesPOO
{
    internal class Almacen
    {
        private Venta[] ventas;

        public Almacen()
        {
            ventas = new Venta[100];
        }

        public void crearVenta(Cliente cte, int valorVenta, Fecha fecha)
        {
            bool respuesta = false;

            for (int i = 0; i < ventas.Length; i++)
            {
                if (ventas[i] == null)
                {
                    ventas[i] = new Venta(i + 1, valorVenta, cte, fecha);
                    respuesta = true;
                    break;
                }
            }

            if (respuesta)
            {
                MessageBox.Show("La Venta fue creada correctamente");
            }
            else
            {
                MessageBox.Show("No se pudo crear la venta, ocurrió un error");
            }
        }

        public Venta getUltimaVentaAgregada()
        {
            //Creación de la variable objeto de tipo venta, la inicializamos en NULL
            Venta venta = null;

            //Verifica que por lo menos exista una venta en el Array de objetos de tipo venta
            if (ventas[0] != null)
            {
                for (int i = 1; i < ventas.Length; i++)
                {
                    //Si la posición actual de i es NULL, quiere decir que la posición anterior es la última venta
                    if (ventas[i] == null)
                    {
                        //Almacenamos la venta en la variable objeto de tipo venta
                        venta = ventas[i - 1];
                        break;
                    }
                }
            }

            //Retornamos la variable
            return venta;
        }

        public Venta[] getVentas()
        {
            return ventas;
        }
    }
}
