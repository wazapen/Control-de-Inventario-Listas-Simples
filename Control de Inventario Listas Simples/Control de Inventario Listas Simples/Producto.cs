using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Control_de_Inventario_Listas_Simples
{
    class Producto
    {
        private string _nombre;
        public string getNombre()
        {
            return _nombre;
        }
        private int _código;
        public int getCódigo()
        {
            return _código;
        }
        private int _cantidad;
        public int getCantidad()
        {
            return _cantidad;
        }
        private double _precio;
        public double getPrecio()
        {
            return _precio;
        }

        private Producto _siguiente;
        public Producto siguiente
        {
            get { return _siguiente; }
            set { _siguiente = value; }
        }

        public void producto(string nombre, int código, int cantidad, double precio)
        {
            _nombre = nombre;
            _código = código;
            _cantidad = cantidad;
            _precio = precio;

        }



        public override string ToString()
        {
            return _código + "\r\n" + _nombre + "\r\n" + _cantidad + "\r\n" + _precio + "\r\n";
        }
    }
}
