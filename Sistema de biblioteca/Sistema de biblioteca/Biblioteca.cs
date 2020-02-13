﻿using System;
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

        public void DevolverLibro(string devolverLibro)
        {
            for (int i = 0; i < ListaPrestamos.Count; i++)
            {
                if (ListaPrestamos[i].ObtenerNombre() == devolverLibro)
                {
                    ListaPrestamos.Remove(ListaPrestamos[i]);
                }
            }
        }

        public void ListadePrestamos() 
        {
            foreach (var item in this.ListaPrestamos)
            {
                Console.WriteLine(item.ObtenerNombre());
            }
        }
    }
}