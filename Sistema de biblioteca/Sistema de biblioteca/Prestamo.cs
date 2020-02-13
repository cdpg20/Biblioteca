using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_biblioteca
{
    public class Prestamo
    {
        List<Usuario> ListaPrestamos = new List<Usuario>();
        List<Usuario> ListaReservas = new List<Usuario>();
        string nombre;
        int cantidad;
        private int reservasYPrestamos = 0;

        public Prestamo(string nombre, int cantidad)
        {
            this.nombre = nombre;
            this.cantidad = cantidad;
        }

        public void ReservarLIbro(Usuario usuario)
        {
            if (reservasYPrestamos < cantidad)
            {
                ListaReservas.Add(usuario);
                reservasYPrestamos++;
            }
            else
            {
                System.Console.WriteLine("El libro no esta disponible para su reserva");
            }
            System.Console.WriteLine($"El libro fue reservado por {usuario.ObtenerNombre()}");
        }

        public void PrestamoLibro(Usuario libro)
        {
            if (ListaReservas.Exists(u => u.ObtenerCi().Equals(libro)))
            {
                Usuario aux = ListaReservas.Find(u => u.ObtenerCi().Equals(libro.ObtenerCi()));
                ListaReservas.Remove(aux);
                ListaPrestamos.Add(libro);
            }
            else if (ListaReservas.Count + ListaPrestamos.Count < cantidad)
            {
                ListaPrestamos.Add(libro);
                reservasYPrestamos++;
            }
            else
            {
                Console.WriteLine("El libro no se esta disponible para reserva");
            }
            Console.WriteLine($"El libro fue prestado a {libro.ObtenerNombre()}");
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
