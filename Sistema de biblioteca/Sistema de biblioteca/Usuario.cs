using System;
using System.Collections.Generic;

namespace Sistema_de_biblioteca
{
    public class Usuario
    {
        string nombre;
        string apellido;
        int ci;
        int numeroTelefono;
        private string codigoUsuario;
        List<Libro> ListaLibrosPrestados = new List<Libro>();
        List<Libro> ListaLibrosReservado = new List<Libro>();

        public Usuario(string nombre)
        {
             this.nombre = nombre;
        }

        public Usuario(string nombre, string apellido, int ci, int numeroTelefono, DateTime fechaNacimiento, string codigoUsuario)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.ci = ci;
            this.numeroTelefono = numeroTelefono;
            this.codigoUsuario = ci + fechaNacimiento.Year.ToString() + fechaNacimiento.Month.ToString();
        }

        public String ObtenerNombre()
        {
            return nombre;
        }

        public String ObtenerApellido()
        {
            return nombre;
        }

        public String ObtenerNombreCompleto()
        {
            return nombre + apellido;
        }

        public int ObtenerCi()
        {
            return ci;
        }

        public int ObtenerNumeroTelefono()
        {
            return numeroTelefono;
        }

        public string ObtenerCodigoUsusario()
        {
            return codigoUsuario;
        }

        public void AgregarLibroPrestado(Libro libroPrestado)
        {
            ListaLibrosPrestados.Add(libroPrestado);
        }

        public void AgregarLibroReservado(Libro libroReservado)
        {
            ListaLibrosReservado.Add(libroReservado);
        }
    }
}
