using System;
using System.Collections.Generic;

namespace Sistema_de_biblioteca
{
    public class Biblioteca
    {
        private readonly static Biblioteca _instance = new Biblioteca();
        private string direccion;
        List<Libro> listaLibros = new List<Libro>();
        List<Biblioteca> listaSucursales = new List<Biblioteca>();
        List<Usuario> ListaPrestamos = new List<Usuario>();
        List<Usuario> ListaReservas = new List<Usuario>();
        List<Usuario> listaUsuarios = new List<Usuario>();

        public void AgregarSucursales(Biblioteca sucursal)
        {
            Console.WriteLine("Ingrese Direccion de la Sucursal");
            this.direccion = Console.ReadLine();
            listaSucursales.Add(sucursal);
        }

        public void AgregarLibro(Libro Libro)
        {
            listaLibros.Add(Libro);
        }


        public String ObtenerDireccion()
        {
            return direccion;
        }

        public List<Libro> ObtenerListaLibros()
        {
            return listaLibros;
        }

        public bool BuscarLibro(string buscarLibros)
        {
            for (int i = 0; i < listaLibros.Count; i++)
            {
                if (listaLibros[i].ObtenerNombre().ToLower() == buscarLibros.ToLower())
                {
                    return true;
                }
            }
            return false;
        }

        public void RealizarReserva(Usuario usuario, Libro libro)
        {
            if (ListaReservas.Exists(u => u.ObtenerCi() == usuario.ObtenerCi()) || ListaPrestamos.Exists(u => u.ObtenerCi() == usuario.ObtenerCi()))
            {
                Console.WriteLine($"el usuario {usuario.ObtenerNombre()} ya reservo el libro={libro.ObtenerNombre()}");
            }
            else
            {
                ListaReservas.Add(usuario);
                usuario.AgregarLibroReservado(libro);
            }
        }


        public void Stock(string nombre)
        {
            foreach (var libro in listaLibros)
            {
                if (libro.ObtenerNombre().ToLower() == nombre.ToLower())
                {
                    if (libro.ObtenerCantidad() > 1)
                    {
                        Console.WriteLine("Existen " + libro.ObtenerCantidad() + " de " + nombre);
                        return;
                    }
                }

            }
        }

        public void EliminarLibro(string eliminarlibro)
        {
            for (int i = 0; i < listaLibros.Count; i++)
            {
                if (listaLibros[i].ObtenerNombre() == eliminarlibro)
                {
                    listaLibros.Remove(listaLibros[i]);
                }
            }
        }

        public static Biblioteca Instance
        {
            get
            {
                return _instance;
            }
        }

        public List<Usuario> ListaDeReservas()
        {
            return ListaReservas;
        }

        public void AgregarUsuario(Usuario nombreUsuario)
        {
            listaUsuarios.Add(nombreUsuario);
        }

        public List<Usuario> ListaUsuarios()
        {
            return listaUsuarios;
        }

        internal void ImprimirUsuarios()
        {
            for (int i = 0; i < listaUsuarios.Count; i++)
            {
                Console.WriteLine($"Ingresar {i} para el Usuario={listaUsuarios[i].ObtenerNombre()}");
            }
        }

        public void DevolverLibro(Libro libro, Usuario usuario)
        {
            for (int i = 0; i < ListaPrestamos.Count; i++)
            {
                if (ListaPrestamos[i].ObtenerNombre() == libro.ObtenerNombre())
                {
                    ListaPrestamos.Remove(usuario);
                    usuario.DevolverLibro(libro);
                }
            }
        }

        public void ListaDePrestamos() 
        {
            foreach (var item in this.ListaPrestamos)
            {
                Console.WriteLine(item.ObtenerNombre());
            }
        }
    }
}
