using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_biblioteca
{
    public class Devolucion
    {
        List<Usuario> ListaPrestamos = new List<Usuario>();
        List<Usuario> ListaReservas = new List<Usuario>();
        List<Libro> listaLibros = new List<Libro>();
        string nombre;
        int cantidad;
        private int reservasYPrestamos = 0;

        public Devolucion(string nombre, string autor, int cantidad, string codigoLibro, DateTime fechaDevolucion)
        {
            this.nombre = nombre;
            this.cantidad = cantidad;
        }
        public void DevolucionLibros(Usuario libro)
        {
            if (ListaPrestamos.Exists(u => u.ObtenerCi().Equals(libro.ObtenerCi())))
            {
                Usuario auxiliar = ListaPrestamos.Find(u => u.ObtenerCi().Equals(libro.ObtenerCi()));
                ListaPrestamos.Remove(auxiliar);
                reservasYPrestamos--;
            }

            Console.WriteLine($"El libro fue devuelto por {libro.ObtenerNombre()}");
        }
    }
}
