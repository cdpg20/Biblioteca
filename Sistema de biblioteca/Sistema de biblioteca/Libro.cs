using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_biblioteca
{
    public class Libro
    {
        string nombre;
        string autor;
        string editorial;
        int cantidad;
        private string codigoLibro;
        DateTime fechaDevolucion;

        public string Autor { get => autor; set => autor = value; }
        public string Editorial { get => editorial; set => editorial = value; }
        public string CodigoLibro { get => codigoLibro; set => codigoLibro = value; }

        public Libro(string nombre, string autor, int cantidad, string codigoLibro, DateTime fechaDevolucion) 
        {
            this.nombre = nombre;
            this.Autor = autor;
            this.cantidad = cantidad;
            this.CodigoLibro = codigoLibro;
            this.fechaDevolucion = fechaDevolucion;
        }

        public Libro(string nombre, string autor, string editorial, int catindad, DateTime fecha, string codigoLibro)
        {
            this.nombre = nombre;
            this.Autor = autor;
            this.Editorial = editorial;
            this.cantidad = catindad;
            this.CodigoLibro = nombre + autor + fecha.Year.ToString();
        }
        
        public String ObtenerNombre()
        {
            return nombre;
        }

        public void Cantidad(int cantidad)
        {
            this.cantidad = cantidad;
        }

        public int ObtenerCantidad()
        {
            return cantidad;
        }
    }
}
