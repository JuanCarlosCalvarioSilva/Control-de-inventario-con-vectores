using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control_de_inventario
{
    class Inventario
    {
        Producto[] listaDeProductos = new Producto[16];
        private int _posicionProducto = 1;
        public void agregar(Producto producto)
        {
            listaDeProductos[_posicionProducto] = producto;
            _posicionProducto++;
        }

        public Producto buscar(int codigo)
        {
            int i=1;
            Producto encontrado = new Producto();
            while (listaDeProductos[i] != null)
            {
                if (listaDeProductos[i].codigo == codigo)
                {
                    encontrado = listaDeProductos[i];
                    break;
                }         
                i++;
            }

            return encontrado;
        }

        public void borrar(int codigo)
        {
            int i = 1;
            while(listaDeProductos[i]!=null)
            {
              if (listaDeProductos[i].codigo == codigo)
                {                                    
                    while (listaDeProductos[i] != null)
                    {
                        listaDeProductos[i] = listaDeProductos[i + 1];
                        i++;
                    }                   
                }
                i++;
                _posicionProducto = i-2;
            }           
        }

        public string reporte()
        {
            string cad = "";
            for (int i = 1; i < listaDeProductos.Length; i++)
                cad += listaDeProductos[i] + Environment.NewLine;
            return cad;
        }

        public void insertar(Producto producto, int posicion)
        {
            for (int i = _posicionProducto; i > posicion ; i--)
            {
                listaDeProductos[i] = listaDeProductos[i - 1];
            }
            listaDeProductos[posicion] = producto;
            _posicionProducto++;
        }
    }
}
