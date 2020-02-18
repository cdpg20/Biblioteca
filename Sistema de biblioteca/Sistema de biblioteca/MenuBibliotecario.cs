using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_biblioteca
{
    public class MenuBibliotecario
    {
        public static   void Bibliotecario()
        {
            int op;
            Console.WriteLine("BIENVENIDO");
            Console.WriteLine("INGRESE LA OPCION QUE DESEA REALIZAR:");
            Console.WriteLine("BUSCAR LIBRO(1), VERIFICAR LISTAS(2), REGISTRAR LIBRO(3), ELIMINAR LIBRO(4), REGISTRAR PRETAMO(5), REGISTRAR RESERVA(6)");
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
                            Console.WriteLine("Los libros registrados son:");
                            Console.Write(Biblioteca.Instance.ObtenerListaLibros());
                        }
                        break;
                    case 3:
                        {
                            Console.WriteLine("Ingrese el libro que desa agregar:");
                            string libro = Console.ReadLine();
                            Console.WriteLine();
                            //Biblioteca.Instance.BuscarLibro(new Libro(libro));
                        }
                        break;
                    case 4:
                        {
                            Console.WriteLine("Ingrese el libro que desa eliminar:");
                            string elimnarlibro = Console.ReadLine();
                            Biblioteca.Instance.EliminarLibro( elimnarlibro);
                        }
                        break;
                    case 5:
                        {
                            Console.WriteLine("Ingrese el libro que desa Prestar:");
                            string libroPrestado = Console.ReadLine();
                            Usuario usuario = new Usuario(libroPrestado);
                            //usuario.AgregarLibroPrestado(new Libro( libroPrestado));
                        }
                        break;
                    case 6:
                        {
                            Console.WriteLine("Ingrese el libro que desa Reservar:");
                            string libro = Console.ReadLine();
                            Usuario usuario = new Usuario(libro);
                           //usuario.AgregarLibroReservado(new Libro(libro));
                        }
                        break;

                    }
            }
        }   
    }
}
