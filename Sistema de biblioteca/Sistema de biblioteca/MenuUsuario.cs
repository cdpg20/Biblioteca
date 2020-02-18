using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_biblioteca
{
    public class MenuUsuario
    {
        public static void UsuarioMenu()
        {
            int op;
            Console.WriteLine("BIENVENIDO A LA BIBILOTECA");
            Console.WriteLine("INGRESE LA OPCION QUE DESEA REALIZAR:");
            Console.WriteLine("BUSCAR LIBRO(1), CONSULTAR LISTA DE PRESTAMOS(2), CONSULTAR LISTA DE RESERVAS(3), DEVOLVER LIBRO(4), PRESTARSE LIBRO(5), RESERVAR LIBRO(6)");
            op = Int32.Parse(Console.ReadLine());
            if (op < 7 && op > 0)
            {
                switch (op)
                {
                    case 1:
                        {
                            Console.WriteLine("Ingrese el libro que desa buscar:");
                            string libro = Console.ReadLine();
                            Console.WriteLine(Biblioteca.Instance.BuscarLibro(libro));
                        }
                        break;
                    case 2:
                        {
                            Usuario listaPrestamos = new Usuario("Los libros prestados son:");
                            Biblioteca.Instance.ListaDePrestamos();
                        }
                        break;
                    case 3:
                        {
                            Usuario listaReservas = new Usuario("Los libros reservados son:");
                            Biblioteca.Instance.ListaDeReservas();
                        }
                        break;
                    case 4:
                        {
                            Console.WriteLine("Ingrese el libro que desa devolver:");
                            string devolverLibro = Console.ReadLine();
                            Biblioteca.Instance.DevolverLibro(devolverLibro);
                        }
                        break;
                    case 5:
                        {
                            Console.WriteLine("Ingrese el libro que desa Prestarse:");
                            string libroPrestado = Console.ReadLine();
                            Usuario usuario = new Usuario(libroPrestado);
                            //usuario.AgregarLibroPrestado(new Libro());
                        }
                        break;
                }
            }
        }
    }
}
