using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Control_de_Inventario_Listas_Simples
{
    class Inventario
    {
        private Producto first = new Producto();
        private Producto last = new Producto();

        public Inventario()
        {
            first = null;
            last = null;
        }

        public void borrar(int código)
        {
            Producto actual = new Producto();
            actual = first;
            Producto anterior = new Producto();
            anterior = null;
            bool encontrado = false;
            Producto find = null;
            if (first != null)
            {
                while (actual != null || encontrado != true)
                {
                    if (actual.getCódigo() == código)
                    {

                        if(actual == first)
                        {
                            first = first.siguiente;
                        }
                        else if(actual == last)
                        {
                            anterior.siguiente = null;
                            last = anterior;
                        }
                        else
                        {
                            anterior.siguiente = actual.siguiente;
                        }

                        encontrado = true;
                        find = actual;
                    }
                    anterior = actual;
                    actual = actual.siguiente;
                }
            }
            if (!encontrado)
            {
                Console.Write("No se encontró");
            }
        }

        public Producto buscar(int código)
        {
            Producto p = first;

            while (p != null && p.getCódigo() != código)
                p = p.siguiente;

            return p;
        }

        public string reporte()
        {
            Producto actual = new Producto();
            actual = first;
            string find = null;
            if (first != null)
            {
                while (actual != null)
                {
                    find += actual.ToString();
                    actual = actual.siguiente;
                }
            }
            return find;
        }
        public string reporteInverso()
        {
            Producto actual = last;
            Producto anterior = first;

            string find = "";
                find = last.ToString();
            if (first != null)
            {

                while (anterior.siguiente != null)
                {
                    if (anterior.siguiente != actual)
                    {
                        anterior = anterior.siguiente;

                    }
                    else
                    {
                        find += anterior.ToString() + "\r\n";
                        actual = anterior;
                        anterior = first;
                    }

                }
            }
            else
                find = "No hay productos .-.";
            return find;
        }

        public void agregar(Producto nuevo)
        {
            if (first == null)
            {
                first = nuevo;
                first.siguiente = null;
                last = nuevo;
            }
            else
            {
                last.siguiente = nuevo;
                nuevo.siguiente = null;
                last = nuevo;
            }
        }

        //public void agregar (Producto nuevo)
        //{
        //    if (first == null)
        //        first = nuevo;
        //    else
        //        agregar(first, nuevo);
        //}
        //private void agregar (Producto último, Producto nuevo)
        //{
        //    if (último.siguiente == null)
        //        último.siguiente = nuevo;
        //    else
        //        agregar(último.siguiente, nuevo);
        //}

        public void agregarEnInicio(Producto nuevo)
        {
            nuevo.siguiente = first;
            first = nuevo;
        }
        public void insertarEnPos(Producto nuevo, int pos)
        {
            Producto actual = new Producto();
            int contador = 2;
            actual = first;
            bool insertado = false;
            if(first != null)
            {
                while (actual != null && insertado != true)
                {
                    if (contador == pos)
                    {
                        nuevo.siguiente = actual.siguiente;
                        actual.siguiente = nuevo;
                        insertado = true;
                    }
                    else
                    {
                        actual = actual.siguiente;
                        contador++;
                    }
                }
            }
                
        }
    }
}
